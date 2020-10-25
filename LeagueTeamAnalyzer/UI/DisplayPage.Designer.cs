namespace LeagueTeamAnalyzer.UI
{
    partial class DisplayPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.m_tabControl = new System.Windows.Forms.TabControl();
            this.m_masteryTab = new System.Windows.Forms.TabPage();
            this.m_masteryList = new System.Windows.Forms.ListView();
            this.championName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mastery = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.summoner = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.winrate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.wins = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.losses = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.m_recentGamesTab = new System.Windows.Forms.TabPage();
            this.m_recentHistoryList = new System.Windows.Forms.ListView();
            this.championNameRecent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gamesPlayedRecent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.summonerRecent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.winrateRecent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.winsRecent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lossesRecent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.m_tabControl.SuspendLayout();
            this.m_masteryTab.SuspendLayout();
            this.m_recentGamesTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_tabControl
            // 
            this.m_tabControl.Controls.Add(this.m_masteryTab);
            this.m_tabControl.Controls.Add(this.m_recentGamesTab);
            this.m_tabControl.Location = new System.Drawing.Point(3, 3);
            this.m_tabControl.Name = "m_tabControl";
            this.m_tabControl.SelectedIndex = 0;
            this.m_tabControl.Size = new System.Drawing.Size(593, 654);
            this.m_tabControl.TabIndex = 9;
            // 
            // m_masteryTab
            // 
            this.m_masteryTab.Controls.Add(this.m_masteryList);
            this.m_masteryTab.Location = new System.Drawing.Point(4, 22);
            this.m_masteryTab.Name = "m_masteryTab";
            this.m_masteryTab.Padding = new System.Windows.Forms.Padding(3);
            this.m_masteryTab.Size = new System.Drawing.Size(585, 628);
            this.m_masteryTab.TabIndex = 0;
            this.m_masteryTab.Text = "Mastery";
            this.m_masteryTab.UseVisualStyleBackColor = true;
            // 
            // m_masteryList
            // 
            this.m_masteryList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.championName,
            this.mastery,
            this.summoner,
            this.winrate,
            this.wins,
            this.losses});
            this.m_masteryList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_masteryList.HideSelection = false;
            this.m_masteryList.Location = new System.Drawing.Point(-4, 0);
            this.m_masteryList.Name = "m_masteryList";
            this.m_masteryList.Size = new System.Drawing.Size(586, 632);
            this.m_masteryList.TabIndex = 5;
            this.m_masteryList.UseCompatibleStateImageBehavior = false;
            this.m_masteryList.View = System.Windows.Forms.View.Details;
            // 
            // championName
            // 
            this.championName.Text = "Champion";
            this.championName.Width = 102;
            // 
            // mastery
            // 
            this.mastery.Text = "Mastery";
            this.mastery.Width = 100;
            // 
            // summoner
            // 
            this.summoner.Text = "Summoner";
            this.summoner.Width = 130;
            // 
            // winrate
            // 
            this.winrate.Text = "Winrate";
            this.winrate.Width = 75;
            // 
            // wins
            // 
            this.wins.Text = "Wins";
            this.wins.Width = 65;
            // 
            // losses
            // 
            this.losses.Text = "Losses";
            this.losses.Width = 66;
            // 
            // m_recentGamesTab
            // 
            this.m_recentGamesTab.Controls.Add(this.m_recentHistoryList);
            this.m_recentGamesTab.Location = new System.Drawing.Point(4, 22);
            this.m_recentGamesTab.Name = "m_recentGamesTab";
            this.m_recentGamesTab.Padding = new System.Windows.Forms.Padding(3);
            this.m_recentGamesTab.Size = new System.Drawing.Size(585, 628);
            this.m_recentGamesTab.TabIndex = 1;
            this.m_recentGamesTab.Text = "Recent Games";
            this.m_recentGamesTab.UseVisualStyleBackColor = true;
            // 
            // m_recentHistoryList
            // 
            this.m_recentHistoryList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.championNameRecent,
            this.gamesPlayedRecent,
            this.summonerRecent,
            this.winrateRecent,
            this.winsRecent,
            this.lossesRecent});
            this.m_recentHistoryList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_recentHistoryList.HideSelection = false;
            this.m_recentHistoryList.Location = new System.Drawing.Point(0, 0);
            this.m_recentHistoryList.Name = "m_recentHistoryList";
            this.m_recentHistoryList.Size = new System.Drawing.Size(585, 628);
            this.m_recentHistoryList.TabIndex = 0;
            this.m_recentHistoryList.UseCompatibleStateImageBehavior = false;
            this.m_recentHistoryList.View = System.Windows.Forms.View.Details;
            // 
            // championNameRecent
            // 
            this.championNameRecent.Text = "Champion";
            this.championNameRecent.Width = 107;
            // 
            // gamesPlayedRecent
            // 
            this.gamesPlayedRecent.Text = "Games Played";
            this.gamesPlayedRecent.Width = 117;
            // 
            // summonerRecent
            // 
            this.summonerRecent.Text = "Summoner";
            this.summonerRecent.Width = 118;
            // 
            // winrateRecent
            // 
            this.winrateRecent.Text = "Winrate";
            this.winrateRecent.Width = 77;
            // 
            // winsRecent
            // 
            this.winsRecent.Text = "Wins";
            this.winsRecent.Width = 54;
            // 
            // lossesRecent
            // 
            this.lossesRecent.Text = "Losses";
            this.lossesRecent.Width = 66;
            // 
            // DisplayPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.m_tabControl);
            this.Name = "DisplayPage";
            this.Size = new System.Drawing.Size(600, 668);
            this.m_tabControl.ResumeLayout(false);
            this.m_masteryTab.ResumeLayout(false);
            this.m_recentGamesTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl m_tabControl;
        private System.Windows.Forms.TabPage m_masteryTab;
        private System.Windows.Forms.ListView m_masteryList;
        private System.Windows.Forms.ColumnHeader championName;
        private System.Windows.Forms.ColumnHeader mastery;
        private System.Windows.Forms.ColumnHeader summoner;
        private System.Windows.Forms.ColumnHeader winrate;
        private System.Windows.Forms.ColumnHeader wins;
        private System.Windows.Forms.ColumnHeader losses;
        private System.Windows.Forms.TabPage m_recentGamesTab;
        private System.Windows.Forms.ListView m_recentHistoryList;
        private System.Windows.Forms.ColumnHeader championNameRecent;
        private System.Windows.Forms.ColumnHeader gamesPlayedRecent;
        private System.Windows.Forms.ColumnHeader summonerRecent;
        private System.Windows.Forms.ColumnHeader winrateRecent;
        private System.Windows.Forms.ColumnHeader winsRecent;
        private System.Windows.Forms.ColumnHeader lossesRecent;
    }
}
