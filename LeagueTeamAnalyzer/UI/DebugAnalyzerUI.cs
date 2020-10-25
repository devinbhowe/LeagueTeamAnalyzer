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
    public partial class DebugAnalyzerUI : Form, IAnalyzerView, IFormController
    {
        private AnalyzerController m_controller;
        private IPage m_currentPage;

        public DebugAnalyzerUI()
        {
            InitializeComponent();
            m_currentPage = new SummonerSelectPage(this);
            m_Panel.Controls.Add(m_currentPage as SummonerSelectPage);
        }

        public void SetController(AnalyzerController controller)
        {
            m_controller = controller;
        }

        public void PageFinished()
        {
            if (m_currentPage is SummonerSelectPage)
            {
                //
                // Save the summoner names and remove that control page
                //
                List<string> summonerNames = (m_currentPage as SummonerSelectPage).SummonerNames;
                m_Panel.Controls.Remove(m_currentPage as SummonerSelectPage);
                
                //
                // Render the results display page
                //
                m_currentPage = new DisplayPage(this);
                m_Panel.Controls.Add(m_currentPage as DisplayPage);

                //
                // Collect the summoner info to display
                //
                m_controller.GetSummonerInfo(summonerNames);
                DisplayMasteryList();
                DisplayRecentHistoryList();
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

        public void DisplayRecentHistoryList()
        {
            (m_currentPage as DisplayPage).DisplayRecentHistoryList(m_controller.SummonerInfoList);
        }

        public void DisplayMasteryList()
        {
            (m_currentPage as DisplayPage).DisplayMasteryList(m_controller.SummonerInfoList);
        }

        #region Private Methods
        #endregion

        #region Form Handlers
        #endregion
    }
}
