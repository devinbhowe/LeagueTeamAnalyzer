using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeagueTeamAnalyzer.UI
{
    public partial class SummonerSelectPage : UserControl
    {
        private IFormController m_formController;
        private AnalyzerController m_analyzerController;

        public SummonerSelectPage()
        {
            InitializeComponent();
        }

        public void SetFormController(IFormController formController)
        {
            m_formController = formController;
        }

        public void SetAnalyzerController(AnalyzerController controller)
        {
            m_analyzerController = controller;
        }

        public void DisplaySummoner(SummonerInfo summonerInfo)
        {
            AddSummonerToList(summonerInfo);
            m_formController.UpdateDebugTextbox(string.Format("\nSummoner: {0}\nLevel: {1}" +
                                                "\nTier: {2}\nRank: {3}" +
                                                "\nRanked Wins: {4}\nRanked Losses: {5}\n",
                                                summonerInfo.Summoner.Name,
                                                summonerInfo.Summoner.Level,
                                                summonerInfo.SoloDuoLeague == null ? "" : summonerInfo.SoloDuoLeague.Tier,
                                                summonerInfo.SoloDuoLeague == null ? "" : summonerInfo.SoloDuoLeague.Rank,
                                                summonerInfo.SoloDuoLeague == null ? 0 : summonerInfo.SoloDuoLeague.Wins,
                                                summonerInfo.SoloDuoLeague == null ? 0 : summonerInfo.SoloDuoLeague.Losses));
        }

        private void AddSummonerToList(SummonerInfo summonerInfo)
        {
            ListViewItem listViewItem = new ListViewItem(new string[]
            {
                summonerInfo.Summoner.Name,
                summonerInfo.Summoner.Level.ToString(),
                summonerInfo.SoloDuoLeague == null ? "" : string.Format("{0} {1}", summonerInfo.SoloDuoLeague.Tier, summonerInfo.SoloDuoLeague.Rank),
                summonerInfo.SoloDuoLeague == null ? "0" : summonerInfo.SoloDuoLeague.Wins.ToString(),
                summonerInfo.SoloDuoLeague == null ? "0" : summonerInfo.SoloDuoLeague.Losses.ToString()
            });
            m_summonersList.Items.Add(listViewItem);
        }

        private void m_startQueryButton_Click(object sender, EventArgs e)
        {
            m_formController.PageFinishedAsync();
        }

        private void m_addSummoner_Click(object sender, EventArgs e)
        {
            if (m_summonerNameTextbox.Text == "")
                return;

            m_analyzerController.GetSummonerInfo(m_summonerNameTextbox.Text);
            m_summonerNameTextbox.Text = "";
        }
    }
}
