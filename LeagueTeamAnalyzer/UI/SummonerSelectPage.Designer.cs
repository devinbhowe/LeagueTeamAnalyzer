namespace LeagueTeamAnalyzer.UI
{
    partial class SummonerSelectPage
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
            this.m_startQueryButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.m_summonerNameTextbox = new System.Windows.Forms.TextBox();
            this.m_addSummoner = new System.Windows.Forms.Button();
            this.m_summonersList = new System.Windows.Forms.ListView();
            this.summonerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.level = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rank = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rankedWins = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rankedLosses = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // m_startQueryButton
            // 
            this.m_startQueryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_startQueryButton.Location = new System.Drawing.Point(447, 540);
            this.m_startQueryButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.m_startQueryButton.Name = "m_startQueryButton";
            this.m_startQueryButton.Size = new System.Drawing.Size(150, 49);
            this.m_startQueryButton.TabIndex = 0;
            this.m_startQueryButton.Text = "Let\'s Go!";
            this.m_startQueryButton.UseVisualStyleBackColor = true;
            this.m_startQueryButton.Click += new System.EventHandler(this.m_startQueryButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Summoner Name";
            // 
            // m_summonerNameTextbox
            // 
            this.m_summonerNameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_summonerNameTextbox.Location = new System.Drawing.Point(8, 30);
            this.m_summonerNameTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.m_summonerNameTextbox.Name = "m_summonerNameTextbox";
            this.m_summonerNameTextbox.Size = new System.Drawing.Size(338, 26);
            this.m_summonerNameTextbox.TabIndex = 3;
            // 
            // m_addSummoner
            // 
            this.m_addSummoner.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_addSummoner.Location = new System.Drawing.Point(354, 5);
            this.m_addSummoner.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.m_addSummoner.Name = "m_addSummoner";
            this.m_addSummoner.Size = new System.Drawing.Size(243, 49);
            this.m_addSummoner.TabIndex = 5;
            this.m_addSummoner.Text = "Add Summoner";
            this.m_addSummoner.UseVisualStyleBackColor = true;
            this.m_addSummoner.Click += new System.EventHandler(this.m_addSummoner_Click);
            // 
            // m_summonersList
            // 
            this.m_summonersList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.summonerName,
            this.level,
            this.rank,
            this.rankedWins,
            this.rankedLosses});
            this.m_summonersList.HideSelection = false;
            this.m_summonersList.Location = new System.Drawing.Point(7, 64);
            this.m_summonersList.Name = "m_summonersList";
            this.m_summonersList.Size = new System.Drawing.Size(590, 468);
            this.m_summonersList.TabIndex = 7;
            this.m_summonersList.UseCompatibleStateImageBehavior = false;
            this.m_summonersList.View = System.Windows.Forms.View.Details;
            // 
            // summonerName
            // 
            this.summonerName.Text = "Summoner";
            this.summonerName.Width = 132;
            // 
            // level
            // 
            this.level.Text = "Level";
            // 
            // rank
            // 
            this.rank.Text = "Rank";
            this.rank.Width = 102;
            // 
            // rankedWins
            // 
            this.rankedWins.Text = "Ranked Wins";
            this.rankedWins.Width = 146;
            // 
            // rankedLosses
            // 
            this.rankedLosses.Text = "Ranked Losses";
            this.rankedLosses.Width = 145;
            // 
            // SummonerSelectPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.m_summonersList);
            this.Controls.Add(this.m_addSummoner);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_summonerNameTextbox);
            this.Controls.Add(this.m_startQueryButton);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SummonerSelectPage";
            this.Size = new System.Drawing.Size(601, 595);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button m_startQueryButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox m_summonerNameTextbox;
        private System.Windows.Forms.Button m_addSummoner;
        private System.Windows.Forms.ListView m_summonersList;
        private System.Windows.Forms.ColumnHeader summonerName;
        private System.Windows.Forms.ColumnHeader level;
        private System.Windows.Forms.ColumnHeader rank;
        private System.Windows.Forms.ColumnHeader rankedWins;
        private System.Windows.Forms.ColumnHeader rankedLosses;
    }
}
