using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RiotSharp.Endpoints.ChampionMasteryEndpoint;
using LeagueTeamAnalyzer.Enums;

namespace LeagueTeamAnalyzer.UI
{
    public partial class DisplayPage : UserControl, IPage
    {
        private IAnalyzerView m_view;

        public DisplayPage(IAnalyzerView view)
        {
            InitializeComponent();
            InitializeMasteryListSorter();
            m_view = view;
        }

        public void DisplayMasteryList(List<SummonerInfo> summonerInfoList)
        {
            m_masteryList.Items.Clear();
            string[] colorNames = Enum.GetNames(typeof(ColorNames));
            int summonerCount = 0;
            foreach (SummonerInfo summoner in summonerInfoList)
            {
                foreach (ChampionMastery mastery in summoner.ChampionMasteries)
                {

                    ListViewItem item = new ListViewItem(new string[]
                    {
                        LeagueStaticInfo.GetChampionNameByID(mastery.ChampionId),
                        mastery.ChampionPoints.ToString(),
                        summoner.Summoner.Name,
                        "",
                        "",
                        ""
                    });
                    item.BackColor = Color.FromName(colorNames[summonerCount]);
                    m_masteryList.Items.Add(item);
                }
                summonerCount++;
            }
        }

        public void DisplayRecentHistoryList(List<SummonerInfo> summonerInfoList)
        {
            m_recentHistoryList.Items.Clear();
            string[] colorNames = Enum.GetNames(typeof(ColorNames));
            int summonerCount = 0;
            foreach (SummonerInfo summoner in summonerInfoList)
            {
                foreach (RecentChampionSummary summary in summoner.RecentChampionsSummary)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        summary.Champion,
                        summary.GamesPlayed.ToString(),
                        summoner.Summoner.Name,
                        summary.Winrate.ToString(),
                        summary.Wins.ToString(),
                        summary.Losses.ToString()
                    });
                    item.BackColor = Color.FromName(colorNames[summonerCount]);
                    m_recentHistoryList.Items.Add(item);
                }
                summonerCount++;
            }
        }

        #region Private Methods
        private void InitializeMasteryListSorter()
        {
            var sorter = new MasteryListSorter();
            m_masteryList.ListViewItemSorter = sorter;
        }
        #endregion
    }
}
