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
            this.m_recentHistorySummaryTab = new System.Windows.Forms.TabPage();
            this.m_recentHistorySummaryList = new System.Windows.Forms.ListView();
            this.championNameRecent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gamesPlayedRecent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.summonerRecent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.winrateRecent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.winsRecent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lossesRecent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.m_backButton = new System.Windows.Forms.Button();
            this.m_tabControl.SuspendLayout();
            this.m_masteryTab.SuspendLayout();
            this.m_recentHistorySummaryTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_tabControl
            // 
            this.m_tabControl.Controls.Add(this.m_masteryTab);
            this.m_tabControl.Controls.Add(this.m_recentHistorySummaryTab);
            this.m_tabControl.Controls.Add(this.tabPage1);
            this.m_tabControl.Location = new System.Drawing.Point(3, 46);
            this.m_tabControl.Name = "m_tabControl";
            this.m_tabControl.SelectedIndex = 0;
            this.m_tabControl.Size = new System.Drawing.Size(632, 611);
            this.m_tabControl.TabIndex = 9;
            // 
            // m_masteryTab
            // 
            this.m_masteryTab.Controls.Add(this.m_masteryList);
            this.m_masteryTab.Location = new System.Drawing.Point(4, 22);
            this.m_masteryTab.Name = "m_masteryTab";
            this.m_masteryTab.Padding = new System.Windows.Forms.Padding(3);
            this.m_masteryTab.Size = new System.Drawing.Size(624, 585);
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
            this.m_masteryList.Size = new System.Drawing.Size(628, 589);
            this.m_masteryList.TabIndex = 5;
            this.m_masteryList.UseCompatibleStateImageBehavior = false;
            this.m_masteryList.View = System.Windows.Forms.View.Details;
            this.m_masteryList.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.m_masteryList_ColumnClick);
            // 
            // championName
            // 
            this.championName.Text = "Champion";
            this.championName.Width = 136;
            // 
            // mastery
            // 
            this.mastery.Text = "Mastery";
            this.mastery.Width = 100;
            // 
            // summoner
            // 
            this.summoner.Text = "Summoner";
            this.summoner.Width = 170;
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
            this.losses.Width = 71;
            // 
            // m_recentHistorySummaryTab
            // 
            this.m_recentHistorySummaryTab.Controls.Add(this.m_recentHistorySummaryList);
            this.m_recentHistorySummaryTab.Location = new System.Drawing.Point(4, 22);
            this.m_recentHistorySummaryTab.Name = "m_recentHistorySummaryTab";
            this.m_recentHistorySummaryTab.Padding = new System.Windows.Forms.Padding(3);
            this.m_recentHistorySummaryTab.Size = new System.Drawing.Size(624, 585);
            this.m_recentHistorySummaryTab.TabIndex = 1;
            this.m_recentHistorySummaryTab.Text = "Recent History Summary";
            this.m_recentHistorySummaryTab.UseVisualStyleBackColor = true;
            // 
            // m_recentHistorySummaryList
            // 
            this.m_recentHistorySummaryList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.championNameRecent,
            this.gamesPlayedRecent,
            this.summonerRecent,
            this.winrateRecent,
            this.winsRecent,
            this.lossesRecent});
            this.m_recentHistorySummaryList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_recentHistorySummaryList.HideSelection = false;
            this.m_recentHistorySummaryList.Location = new System.Drawing.Point(0, 0);
            this.m_recentHistorySummaryList.Name = "m_recentHistorySummaryList";
            this.m_recentHistorySummaryList.Size = new System.Drawing.Size(621, 628);
            this.m_recentHistorySummaryList.TabIndex = 0;
            this.m_recentHistorySummaryList.UseCompatibleStateImageBehavior = false;
            this.m_recentHistorySummaryList.View = System.Windows.Forms.View.Details;
            this.m_recentHistorySummaryList.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.m_recentHistorySummaryList_ColumnClick);
            // 
            // championNameRecent
            // 
            this.championNameRecent.Text = "Champion";
            this.championNameRecent.Width = 139;
            // 
            // gamesPlayedRecent
            // 
            this.gamesPlayedRecent.Text = "Games Played";
            this.gamesPlayedRecent.Width = 117;
            // 
            // summonerRecent
            // 
            this.summonerRecent.Text = "Summoner";
            this.summonerRecent.Width = 163;
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
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(624, 585);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // m_backButton
            // 
            this.m_backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_backButton.Location = new System.Drawing.Point(7, 9);
            this.m_backButton.Name = "m_backButton";
            this.m_backButton.Size = new System.Drawing.Size(81, 31);
            this.m_backButton.TabIndex = 10;
            this.m_backButton.Text = "Back";
            this.m_backButton.UseVisualStyleBackColor = true;
            this.m_backButton.Click += new System.EventHandler(this.m_backButton_Click);
            // 
            // DisplayPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.m_backButton);
            this.Controls.Add(this.m_tabControl);
            this.Name = "DisplayPage";
            this.Size = new System.Drawing.Size(638, 668);
            this.m_tabControl.ResumeLayout(false);
            this.m_masteryTab.ResumeLayout(false);
            this.m_recentHistorySummaryTab.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage m_recentHistorySummaryTab;
        private System.Windows.Forms.ListView m_recentHistorySummaryList;
        private System.Windows.Forms.ColumnHeader championNameRecent;
        private System.Windows.Forms.ColumnHeader gamesPlayedRecent;
        private System.Windows.Forms.ColumnHeader summonerRecent;
        private System.Windows.Forms.ColumnHeader winrateRecent;
        private System.Windows.Forms.ColumnHeader winsRecent;
        private System.Windows.Forms.ColumnHeader lossesRecent;
        private System.Windows.Forms.Button m_backButton;
        private System.Windows.Forms.TabPage tabPage1;
    }
}
