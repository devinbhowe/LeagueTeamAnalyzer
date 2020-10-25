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
            this.m_summonerNameTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.m_goButton = new System.Windows.Forms.Button();
            this.m_resultsTextbox = new System.Windows.Forms.RichTextBox();
            this.m_masteryList = new System.Windows.Forms.ListView();
            this.championName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mastery = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.summoner = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.winrate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.wins = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.losses = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.m_renderTable = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.m_tabControl = new System.Windows.Forms.TabControl();
            this.m_masteryTab = new System.Windows.Forms.TabPage();
            this.m_recentGamesTab = new System.Windows.Forms.TabPage();
            this.m_recentHistoryList = new System.Windows.Forms.ListView();
            this.championNameRecent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gamesPlayedRecent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.summonerRecent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.winsRecent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lossesRecent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.winrateRecent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.m_tabControl.SuspendLayout();
            this.m_masteryTab.SuspendLayout();
            this.m_recentGamesTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_summonerNameTextbox
            // 
            this.m_summonerNameTextbox.Location = new System.Drawing.Point(12, 32);
            this.m_summonerNameTextbox.Name = "m_summonerNameTextbox";
            this.m_summonerNameTextbox.Size = new System.Drawing.Size(172, 20);
            this.m_summonerNameTextbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Summoner Name";
            // 
            // m_goButton
            // 
            this.m_goButton.Location = new System.Drawing.Point(190, 30);
            this.m_goButton.Name = "m_goButton";
            this.m_goButton.Size = new System.Drawing.Size(75, 23);
            this.m_goButton.TabIndex = 2;
            this.m_goButton.Text = "Add To List";
            this.m_goButton.UseVisualStyleBackColor = true;
            this.m_goButton.Click += new System.EventHandler(this.m_goButton_Click);
            // 
            // m_resultsTextbox
            // 
            this.m_resultsTextbox.Enabled = false;
            this.m_resultsTextbox.Location = new System.Drawing.Point(565, 23);
            this.m_resultsTextbox.Name = "m_resultsTextbox";
            this.m_resultsTextbox.Size = new System.Drawing.Size(223, 685);
            this.m_resultsTextbox.TabIndex = 4;
            this.m_resultsTextbox.Text = "";
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
            this.m_masteryList.Size = new System.Drawing.Size(543, 632);
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
            // m_renderTable
            // 
            this.m_renderTable.Location = new System.Drawing.Point(464, 23);
            this.m_renderTable.Name = "m_renderTable";
            this.m_renderTable.Size = new System.Drawing.Size(95, 23);
            this.m_renderTable.TabIndex = 6;
            this.m_renderTable.Text = "Render Table";
            this.m_renderTable.UseVisualStyleBackColor = true;
            this.m_renderTable.Click += new System.EventHandler(this.m_renderTable_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(562, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Log";
            // 
            // m_tabControl
            // 
            this.m_tabControl.Controls.Add(this.m_masteryTab);
            this.m_tabControl.Controls.Add(this.m_recentGamesTab);
            this.m_tabControl.Location = new System.Drawing.Point(12, 54);
            this.m_tabControl.Name = "m_tabControl";
            this.m_tabControl.SelectedIndex = 0;
            this.m_tabControl.Size = new System.Drawing.Size(547, 654);
            this.m_tabControl.TabIndex = 8;
            // 
            // m_masteryTab
            // 
            this.m_masteryTab.Controls.Add(this.m_masteryList);
            this.m_masteryTab.Location = new System.Drawing.Point(4, 22);
            this.m_masteryTab.Name = "m_masteryTab";
            this.m_masteryTab.Padding = new System.Windows.Forms.Padding(3);
            this.m_masteryTab.Size = new System.Drawing.Size(539, 628);
            this.m_masteryTab.TabIndex = 0;
            this.m_masteryTab.Text = "Mastery";
            this.m_masteryTab.UseVisualStyleBackColor = true;
            // 
            // m_recentGamesTab
            // 
            this.m_recentGamesTab.Controls.Add(this.m_recentHistoryList);
            this.m_recentGamesTab.Location = new System.Drawing.Point(4, 22);
            this.m_recentGamesTab.Name = "m_recentGamesTab";
            this.m_recentGamesTab.Padding = new System.Windows.Forms.Padding(3);
            this.m_recentGamesTab.Size = new System.Drawing.Size(539, 628);
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
            this.m_recentHistoryList.Size = new System.Drawing.Size(543, 628);
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
            // winrateRecent
            // 
            this.winrateRecent.Text = "Winrate";
            this.winrateRecent.Width = 77;
            // 
            // DebugAnalyzerUI
            // 
            this.AcceptButton = this.m_goButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 712);
            this.Controls.Add(this.m_tabControl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.m_renderTable);
            this.Controls.Add(this.m_resultsTextbox);
            this.Controls.Add(this.m_goButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_summonerNameTextbox);
            this.Name = "DebugAnalyzerUI";
            this.Text = "AnalyzerUI";
            this.m_tabControl.ResumeLayout(false);
            this.m_masteryTab.ResumeLayout(false);
            this.m_recentGamesTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox m_summonerNameTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button m_goButton;
        private System.Windows.Forms.RichTextBox m_resultsTextbox;
        private System.Windows.Forms.ListView m_masteryList;
        private System.Windows.Forms.ColumnHeader championName;
        private System.Windows.Forms.ColumnHeader mastery;
        private System.Windows.Forms.ColumnHeader summoner;
        private System.Windows.Forms.ColumnHeader winrate;
        private System.Windows.Forms.ColumnHeader wins;
        private System.Windows.Forms.ColumnHeader losses;
        private System.Windows.Forms.Button m_renderTable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl m_tabControl;
        private System.Windows.Forms.TabPage m_masteryTab;
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