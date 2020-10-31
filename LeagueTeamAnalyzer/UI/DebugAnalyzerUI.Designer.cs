namespace LeagueTeamAnalyzer
{
    partial class DebugAnalyzerUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.m_resultsTextbox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.m_Panel = new System.Windows.Forms.Panel();
            this.m_summonerSelectPage = new LeagueTeamAnalyzer.UI.SummonerSelectPage();
            this.m_displayPage = new LeagueTeamAnalyzer.UI.DisplayPage();
            this.m_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_resultsTextbox
            // 
            this.m_resultsTextbox.Enabled = false;
            this.m_resultsTextbox.Location = new System.Drawing.Point(698, 23);
            this.m_resultsTextbox.Name = "m_resultsTextbox";
            this.m_resultsTextbox.Size = new System.Drawing.Size(223, 667);
            this.m_resultsTextbox.TabIndex = 4;
            this.m_resultsTextbox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(695, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Log";
            // 
            // m_Panel
            // 
            this.m_Panel.Controls.Add(this.m_summonerSelectPage);
            this.m_Panel.Controls.Add(this.m_displayPage);
            this.m_Panel.Location = new System.Drawing.Point(3, 12);
            this.m_Panel.Name = "m_Panel";
            this.m_Panel.Size = new System.Drawing.Size(689, 677);
            this.m_Panel.TabIndex = 8;
            // 
            // m_summonerSelectPage
            // 
            this.m_summonerSelectPage.AutoSize = true;
            this.m_summonerSelectPage.Location = new System.Drawing.Point(3, 0);
            this.m_summonerSelectPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.m_summonerSelectPage.Name = "m_summonerSelectPage";
            this.m_summonerSelectPage.Size = new System.Drawing.Size(687, 676);
            this.m_summonerSelectPage.TabIndex = 1;
            // 
            // m_displayPage
            // 
            this.m_displayPage.Location = new System.Drawing.Point(0, 0);
            this.m_displayPage.Name = "m_displayPage";
            this.m_displayPage.Size = new System.Drawing.Size(687, 673);
            this.m_displayPage.TabIndex = 0;
            this.m_displayPage.Visible = false;
            // 
            // DebugAnalyzerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 690);
            this.Controls.Add(this.m_Panel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.m_resultsTextbox);
            this.Name = "DebugAnalyzerUI";
            this.Text = "AnalyzerUI";
            this.m_Panel.ResumeLayout(false);
            this.m_Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox m_resultsTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel m_Panel;
        private UI.SummonerSelectPage m_summonerSelectPage;
        private UI.DisplayPage m_displayPage;
    }
}