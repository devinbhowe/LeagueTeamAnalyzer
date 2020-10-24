using LeagueTeamAnalyzer.Enums;
using LeagueTeamAnalyzer.Exceptions;
using LeagueTeamAnalyzer.UI;
using RiotSharp.Endpoints.ChampionMasteryEndpoint;
using RiotSharp.Endpoints.StaticDataEndpoint.Champion;
using RiotSharp.Endpoints.SummonerEndpoint;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeagueTeamAnalyzer
{
    public partial class DebugAnalyzerUI : Form, IAnalyzerView
    {
        private AnalyzerController m_controller;

        public DebugAnalyzerUI()
        {
            InitializeComponent();
            InitializeColumnSorter();
        }

        public void SetController(AnalyzerController controller)
        {
            m_controller = controller;
        }

        public void DisplayMasteryList(List<SummonerInfo> summoners)
        {
            m_masteryList.Items.Clear();
            string [] colorNames = Enum.GetNames(typeof(ColorNames));
            int summonerCount = 0;
            foreach (SummonerInfo summoner in summoners)
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

        public void DisplayResults(object item)
        {
            var type = item.GetType();
            if (type == typeof(SummonerInfo))
            {
                SummonerInfo summonerInfo = item as SummonerInfo;
                m_resultsTextbox.Text += string.Format("\nSummoner: {0}\nLevel: {1}" +
                                                        "\nTier: {2}\nRank: {3}" +
                                                        "\nRanked Wins: {4}\nRanked Losses: {5}\n",
                                                        summonerInfo.Summoner.Name,
                                                        summonerInfo.Summoner.Level,
                                                        summonerInfo.SoloDuoLeague == null ? "" : summonerInfo.SoloDuoLeague.Tier,
                                                        summonerInfo.SoloDuoLeague == null ? "" : summonerInfo.SoloDuoLeague.Rank,
                                                        summonerInfo.SoloDuoLeague == null ? 0 : summonerInfo.SoloDuoLeague.Wins,
                                                        summonerInfo.SoloDuoLeague== null ? 0 : summonerInfo.SoloDuoLeague.Losses);
            }
        }

        public void DisplayFailure(Exception ex)
        {
            m_resultsTextbox.Text += "\nFailure!!";

            if (ex is APICallException)
            {
                m_resultsTextbox.Text += string.Format("\nAPI Call Exception: \n{0}", ex.Message);
            }
            else
            {
                m_resultsTextbox.Text += string.Format("\n{0}", ex.Message);
            }
        }

        #region Private Methods
        private void InitializeColumnSorter()
        {
            var sorter = new MasteryListSorter();
            m_masteryList.ListViewItemSorter = sorter;
        }
        #endregion

        #region Form Handlers
        private void m_goButton_Click(object sender, EventArgs e)
        {
            if (m_summonerNameTextbox.Text == "")
                return;

            m_controller.GetSummonerInfo(m_summonerNameTextbox.Text);
            m_summonerNameTextbox.Text = "";
        }

        private void m_renderTable_Click(object sender, EventArgs e)
        {
            DisplayMasteryList(m_controller.m_summonerInfoList);
        }
        #endregion
    }
}
