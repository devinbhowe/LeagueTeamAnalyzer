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
    public partial class SummonerSelectPage : UserControl, IPage
    {
        public List<string> SummonerNames;

        private IAnalyzerView m_view;
        
        public SummonerSelectPage(IAnalyzerView view)
        {
            InitializeComponent();
            m_view = view;
            SummonerNames = new List<string>();
        }

        private void m_startQueryButton_Click(object sender, EventArgs e)
        {
            m_view.PageFinished();
        }

        private void m_addSummoner_Click(object sender, EventArgs e)
        {
            if (m_summonerNameTextbox.Text == "")
                return;

            m_summonersComboBox.Items.Add(m_summonerNameTextbox.Text);
            SummonerNames.Add(m_summonerNameTextbox.Text);
            m_summonerNameTextbox.Text = "";
        }
    }
}
