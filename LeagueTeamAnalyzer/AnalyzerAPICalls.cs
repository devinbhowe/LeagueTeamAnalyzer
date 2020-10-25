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
using RiotSharp.Endpoints.TeamEndpoint;

namespace LeagueTeamAnalyzer
{
    public class AnalyzerAPICalls
    {
        private RiotApi m_riotApi;
        public AnalyzerAPICalls()
        {
            m_riotApi = RiotApi.GetDevelopmentInstance("RGAPI-9c69b0c6-43b3-4716-85c0-8f49768a8f5a");
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
                var matchlistTask = m_riotApi.Match.GetMatchListAsync(Region.Na, summoner.AccountId);

                Dictionary<long, Task<Match>> matchInfoTasks = new Dictionary<long, Task<Match>>();
                foreach (var match in matchlistTask.Result.Matches)
                {
                    matchInfoTasks.Add(match.GameId, m_riotApi.Match.GetMatchAsync(Region.Na, match.GameId));
                }

                Dictionary<long, Match> matchInfo = new Dictionary<long, Match>();
                foreach (var match in matchInfoTasks)
                {
                    matchInfo.Add(match.Key, match.Value.Result);
                }

                return new SummonerInfo(summoner, masteryTask.Result, leagueTask.Result, matchlistTask.Result, matchInfo);
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
        public MatchList MatchList;
        public List<RecentChampionSummary> RecentChampionsSummary;
        public Dictionary<long, Match> MatchInfo;

        public SummonerInfo(Summoner summoner, 
                            List<ChampionMastery> championMasteries, 
                            List<LeagueEntry> leagueEntries,
                            MatchList matchList,
                            Dictionary<long, Match> matchInfo)
        {
            Summoner = summoner;
            ChampionMasteries = championMasteries;
            SoloDuoLeague = leagueEntries.Where(a => a.QueueType == QueueType.RANKED_SOLO_5x5.ToString()).FirstOrDefault();
            MatchList = matchList;
            MatchInfo = matchInfo;
            CompileRecentHistory();
        }

        private void CompileRecentHistory()
        {
            Dictionary<string, RecentChampionSummary> recentChampionsSummary = new Dictionary<string, RecentChampionSummary>();
            foreach (var match in MatchInfo)
            {
                foreach (var player in match.Value.Participants)
                {
                    //
                    // Look through each player in each match, find the player in question
                    //
                    if (player.ParticipantId.ToString() != Summoner.Id)
                        continue;

                    string champion = LeagueStaticInfo.GetChampionNameByID(player.ChampionId);
                    if (!recentChampionsSummary.ContainsKey(champion))
                        recentChampionsSummary.Add(champion, new RecentChampionSummary(champion));

                    var team = match.Value.Teams.Where(a => a.TeamId == player.TeamId).First();
                    if (team.Win == "Yes")
                        recentChampionsSummary[champion].Wins++;
                    else
                        recentChampionsSummary[champion].Losses++; 
                }
            }
            RecentChampionsSummary = recentChampionsSummary.Select(a => a.Value).ToList();
        }
    }

    public class RecentChampionSummary
    {
        //
        // Compiled info for one champ from a player's recent history
        //
        public string Champion
        {
            get; private set;
        }
        public int Wins = 0;
        public int Losses = 0;
        public double Winrate
        {
            get
            {
                return (double)Wins / (double)Losses;
            }
        }
        public int GamesPlayed
        {
            get
            {
                return Wins + Losses;
            }
        }

        public RecentChampionSummary(string championName)
        {
            Champion = championName;
        }
    }
}
