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
            this.wins = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.losses = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.winrate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.m_renderTable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_summonerNameTextbox
            // 
            this.m_summonerNameTextbox.Location = new System.Drawing.Point(12, 27);
            this.m_summonerNameTextbox.Name = "m_summonerNameTextbox";
            this.m_summonerNameTextbox.Size = new System.Drawing.Size(172, 20);
            this.m_summonerNameTextbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Summoner Name";
            // 
            // m_goButton
            // 
            this.m_goButton.Location = new System.Drawing.Point(190, 25);
            this.m_goButton.Name = "m_goButton";
            this.m_goButton.Size = new System.Drawing.Size(75, 23);
            this.m_goButton.TabIndex = 2;
            this.m_goButton.Text = "Go!";
            this.m_goButton.UseVisualStyleBackColor = true;
            this.m_goButton.Click += new System.EventHandler(this.m_goButton_Click);
            // 
            // m_resultsTextbox
            // 
            this.m_resultsTextbox.Location = new System.Drawing.Point(565, 25);
            this.m_resultsTextbox.Name = "m_resultsTextbox";
            this.m_resultsTextbox.Size = new System.Drawing.Size(223, 413);
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
            this.m_masteryList.HideSelection = false;
            this.m_masteryList.Location = new System.Drawing.Point(12, 53);
            this.m_masteryList.Name = "m_masteryList";
            this.m_masteryList.Size = new System.Drawing.Size(547, 385);
            this.m_masteryList.TabIndex = 5;
            this.m_masteryList.UseCompatibleStateImageBehavior = false;
            this.m_masteryList.View = System.Windows.Forms.View.Details;
            // 
            // championName
            // 
            this.championName.Text = "Champion";
            this.championName.Width = 100;
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
            // wins
            // 
            this.wins.Text = "Wins";
            // 
            // losses
            // 
            this.losses.Text = "Losses";
            // 
            // winrate
            // 
            this.winrate.Text = "Winrate";
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
            // DebugAnalyzerUI
            // 
            this.AcceptButton = this.m_goButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.m_renderTable);
            this.Controls.Add(this.m_masteryList);
            this.Controls.Add(this.m_resultsTextbox);
            this.Controls.Add(this.m_goButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_summonerNameTextbox);
            this.Name = "DebugAnalyzerUI";
            this.Text = "AnalyzerUI";
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
    }
}