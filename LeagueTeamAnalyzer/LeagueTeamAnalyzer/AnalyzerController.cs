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

        public AnalyzerController()
        {
            m_apiCalls = new AnalyzerAPICalls();
        }

        public void GetSummonerInfo(string summonerName)
        {
            var summoner = m_apiCalls.GetSummonerData(summonerName);
        }
    }
}
