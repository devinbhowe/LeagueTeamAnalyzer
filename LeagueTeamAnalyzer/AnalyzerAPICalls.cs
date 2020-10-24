using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RiotSharp;
using RiotSharp.Misc;
using RiotSharp.Endpoints.SummonerEndpoint;
using LeagueTeamAnalyzer.Exceptions;
using RiotSharp.Endpoints.MatchEndpoint;
using RiotSharp.Endpoints.LeagueEndpoint;
using RiotSharp.Endpoints.ChampionMasteryEndpoint;
using LeagueTeamAnalyzer.Enums;
using RiotSharp.Endpoints.StaticDataEndpoint.Champion;

namespace LeagueTeamAnalyzer
{
    public class AnalyzerAPICalls
    {
        private RiotApi m_riotApi;
        public AnalyzerAPICalls()
        {
            m_riotApi = RiotApi.GetDevelopmentInstance("RGAPI-be55c3fa-53d5-4564-afce-468e7779ba3a");
            new LeagueStaticInfo(m_riotApi);
        }

        public SummonerInfo GetSummonerInfo(string summonerName)
        {
            try
            {
                //
                // Wait on this first, need encrypted summoner ID
                //
                var summoner = m_riotApi.Summoner.GetSummonerByNameAsync(Region.Na, summonerName).Result;

                var masteryTask = m_riotApi.ChampionMastery.GetChampionMasteriesAsync(Region.Na, summoner.Id);
                var leagueTask = m_riotApi.League.GetLeagueEntriesBySummonerAsync(Region.Na, summoner.Id);
                Task.WaitAll(new Task[] { masteryTask, leagueTask }); // Wait for all to complete
                return new SummonerInfo(summoner, masteryTask.Result, leagueTask.Result);
            }
            catch (Exception ex)
            {
                throw new APICallException(APICallExceptionType.InvalidSummonerName, string.Format("Summoner Name not found: {0}", summonerName));
            }
        }
    }

    public class SummonerInfo
    {
        //
        // Wrapper on RiotSharp.Summoner with some added info
        //
        public Summoner Summoner;
        public List<ChampionMastery> ChampionMasteries;
        public LeagueEntry SoloDuoLeague;

        public SummonerInfo(Summoner summoner, 
                            List<ChampionMastery> championMasteries, 
                            List<LeagueEntry> leagueEntries)
        {
            Summoner = summoner;
            ChampionMasteries = championMasteries;
            SoloDuoLeague = leagueEntries.Where(a => a.QueueType == QueueType.RANKED_SOLO_5x5.ToString()).FirstOrDefault();
        }
    }
}
