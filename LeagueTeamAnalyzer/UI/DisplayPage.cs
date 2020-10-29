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
    public partial class DisplayPage : UserControl
    {
        private IFormController m_formController;
        private AnalyzerController m_analyzerController;

        public DisplayPage( )
        {
            InitializeComponent();
            InitializeMasteryListSorter();
        }

        public void SetFormController(IFormController formController)
        {
            m_formController = formController;
        }

        public void SetAnalyzerController(AnalyzerController controller)
        {
            m_analyzerController = controller;
        }

        public void DisplayMasteryList()
        {
            m_masteryList.Items.Clear();
            string[] colorNames = Enum.GetNames(typeof(ColorNames));
            int summonerCount = 0;
            foreach (SummonerInfo summoner in m_analyzerController.SummonerInfoList)
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

        public void DisplayRecentHistoryList()
        {
            m_recentHistoryList.Items.Clear();
            string[] colorNames = Enum.GetNames(typeof(ColorNames));
            int summonerCount = 0;
            foreach (SummonerInfo summoner in m_analyzerController.SummonerInfoList)
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

        private void m_backButton_Click(object sender, EventArgs e)
        {
            m_formController.PageFinishedAsync();
        }
    }
}
