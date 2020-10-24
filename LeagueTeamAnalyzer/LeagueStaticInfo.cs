using RiotSharp;
using RiotSharp.Endpoints.StaticDataEndpoint.Champion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueTeamAnalyzer
{
    public class LeagueStaticInfo
    {
        private static ChampionListStatic m_championListStatic;

        public LeagueStaticInfo(RiotApi riotApi)
        {
            m_championListStatic = riotApi.DataDragon.Champions.GetAllAsync(ConfigurationManager.LeaguePatch).Result;
        }

        public static string GetChampionNameByID(long id)
        {
            return m_championListStatic.Champions.Where(a => a.Value.Id == id).FirstOrDefault().Key;
        }
    }
}
