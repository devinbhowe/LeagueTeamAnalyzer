using LeagueTeamAnalyzer.Enums;
using RiotSharp.Endpoints.ChampionMasteryEndpoint;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace LeagueTeamAnalyzer.UI
{
    public partial class DisplayPage : UserControl
    {
        private IFormController m_formController;
        private AnalyzerController m_analyzerController;

        public DisplayPage( )
        {
            InitializeComponent();
            InitializeListViewSorters();
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
            m_recentHistorySummaryList.Items.Clear();
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
                        summary.Winrate.ToString("0%"),
                        summary.Wins.ToString(),
                        summary.Losses.ToString()
                    });
                    item.BackColor = Color.FromName(colorNames[summonerCount]);
                    m_recentHistorySummaryList.Items.Add(item);
                }
                summonerCount++;
            }
        }

        #region Private Methods
        private void InitializeListViewSorters()
        {
            List<Type> columnTypes = new List<Type>() { typeof(string), typeof(int), typeof(string), typeof(double), typeof(int), typeof(int) };
            var sorter = new SimpleNumberSorter(1, columnTypes);
            m_masteryList.ListViewItemSorter = sorter;
            m_recentHistorySummaryList.ListViewItemSorter = sorter;
        }
        #endregion

        private void m_backButton_Click(object sender, EventArgs e)
        {
            m_formController.PageFinished();
        }

        private void m_recentHistorySummaryList_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            (m_recentHistorySummaryList.ListViewItemSorter as SimpleNumberSorter).ColumnToSort = e.Column;
            m_recentHistorySummaryList.Sort();
        }

        private void m_masteryList_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            (m_masteryList.ListViewItemSorter as SimpleNumberSorter).ColumnToSort = e.Column;
            m_masteryList.Sort();
        }
    }
}
