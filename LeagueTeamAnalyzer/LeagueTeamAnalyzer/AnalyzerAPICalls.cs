using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RiotSharp;
using RiotSharp.Misc;
using RiotSharp.Endpoints.SummonerEndpoint;
using LeagueTeamAnalyzer.Exceptions;

namespace LeagueTeamAnalyzer
{
    public class AnalyzerAPICalls
    {
        private RiotApi m_riotApi;

        public AnalyzerAPICalls()
        {
            m_riotApi = RiotApi.GetDevelopmentInstance("RGAPI-be55c3fa-53d5-4564-afce-468e7779ba3a");
        }

        public Summoner GetSummonerData(string summonerName)
        {
            try
            {
                var summoner = m_riotApi.Summoner.GetSummonerByNameAsync(Region.Na, summonerName).Result;
                var thing = summoner.GetLeagues();
                return summoner;
            }
            catch
            {
                throw new APICallException(APICallExceptionType.InvalidSummonerName, "Summoner name invalid");
            }
        }
    }
}
