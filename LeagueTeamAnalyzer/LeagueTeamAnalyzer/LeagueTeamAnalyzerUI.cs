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
    public partial class LeagueTeamAnalyzerUI : Form
    {
        AnalyzerController m_controller;

        public LeagueTeamAnalyzerUI()
        {
            InitializeComponent();
            m_controller = new AnalyzerController();
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            if (summonerNameTextBox.Text == "")
                return;

            m_controller.GetSummonerInfo(summonerNameTextBox.Text);
        }
    }
}
