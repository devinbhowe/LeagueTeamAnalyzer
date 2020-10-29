using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LeagueTeamAnalyzer
{
    public class AnalyzerController
    {
        AnalyzerAPICalls m_apiCalls;
        IAnalyzerView m_view;
        public List<SummonerInfo> SummonerInfoList;

        public AnalyzerController(IAnalyzerView view)
        {
            m_view = view;
            m_apiCalls = new AnalyzerAPICalls();
            SummonerInfoList = new List<SummonerInfo>();
        }

        public async Task GetSummonerInfo(List<string> summonerNames)
        {
            await Task.Run(() =>
            {
                foreach (string summoner in summonerNames)
                {
                    GetSummonerInfo(summoner);
                    Thread.Sleep(2000); // Wait 2 seconds to stop rate limit exceeding
                }
            });
        }

        public SummonerInfo GetSummonerInfo(string summonerName)
        {
            if (SummonerInfoList.Where(a => a.Summoner.Name.ToUpper().Replace(" ", "") == summonerName.ToUpper()).Count() != 0)
                return null;

            try
            {
                var summonerInfo = m_apiCalls.GetSummonerInfo(summonerName);
                SummonerInfoList.Add(summonerInfo);
                m_view.DisplayResults(summonerInfo);
                return summonerInfo;
            }
            catch (Exception ex)
            {
                m_view.DisplayFailure(ex);
                return null;
            }
        }
    }
}
