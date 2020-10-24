using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueTeamAnalyzer
{
    public class AnalyzerController
    {
        AnalyzerAPICalls m_apiCalls;
        IAnalyzerView m_view;
        public List<SummonerInfo> m_summonerInfoList;

        public AnalyzerController(IAnalyzerView view)
        {
            m_view = view;
            m_apiCalls = new AnalyzerAPICalls();
            m_summonerInfoList = new List<SummonerInfo>();
        }

        public void GetSummonerInfo(string summonerName)
        {
            try
            {
                var summonerInfo = m_apiCalls.GetSummonerInfo(summonerName);
                m_summonerInfoList.Add(summonerInfo);
                m_view.DisplayResults(summonerInfo);
            }
            catch (Exception ex)
            {
                m_view.DisplayFailure(ex);
            }
        }
    }
}
