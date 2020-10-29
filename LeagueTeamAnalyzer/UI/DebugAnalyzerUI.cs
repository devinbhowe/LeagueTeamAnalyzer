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

        public DebugAnalyzerUI()
        {
            InitializeComponent();
            m_summonerSelectPage.SetFormController(this);
            m_displayPage.SetFormController(this);
        }

        public void SetController(AnalyzerController controller)
        {
            m_controller = controller;
            m_displayPage.SetAnalyzerController(controller);
            m_summonerSelectPage.SetAnalyzerController(controller);
        }

        public async Task PageFinishedAsync()
        {
            m_summonerSelectPage.Visible = !m_summonerSelectPage.Visible;
            m_displayPage.Visible = !m_displayPage.Visible;

            if (m_displayPage.Visible)
            {
                m_displayPage.DisplayMasteryList();
                m_displayPage.DisplayRecentHistoryList();
            }
        }

        public void DisplayResults(object item)
        {
            var type = item.GetType();
            if (type == typeof(SummonerInfo))
            {
                SummonerInfo summonerInfo = item as SummonerInfo;
                m_summonerSelectPage.DisplaySummoner(summonerInfo);
            }
        }

        public void DisplayFailure(Exception ex)
        {
            this.m_resultsTextbox.Invoke(new MethodInvoker(delegate ()
            {
                UpdateDebugTextbox("\nFailure!!");

                if (ex is APICallException)
                {
                    UpdateDebugTextbox(string.Format("\nAPI Call Exception: \n{0}", ex.Message));
                }
                else
                {
                    UpdateDebugTextbox(string.Format("\n{0}", ex.Message));
                }
            }));
        }

        public void UpdateDebugTextbox(string text)
        {
            this.m_resultsTextbox.Invoke(new MethodInvoker(delegate ()
            {
                m_resultsTextbox.Text += text;
            }));
        }
        #region Private Methods
        #endregion

        #region Form Handlers
        #endregion
    }
}
