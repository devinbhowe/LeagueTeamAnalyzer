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
            this.m_summonersComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // m_startQueryButton
            // 
            this.m_startQueryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_startQueryButton.Location = new System.Drawing.Point(438, 457);
            this.m_startQueryButton.Name = "m_startQueryButton";
            this.m_startQueryButton.Size = new System.Drawing.Size(100, 32);
            this.m_startQueryButton.TabIndex = 0;
            this.m_startQueryButton.Text = "Let\'s Go!";
            this.m_startQueryButton.UseVisualStyleBackColor = true;
            this.m_startQueryButton.Click += new System.EventHandler(this.m_startQueryButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Summoner Name";
            // 
            // m_summonerNameTextbox
            // 
            this.m_summonerNameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_summonerNameTextbox.Location = new System.Drawing.Point(3, 48);
            this.m_summonerNameTextbox.Name = "m_summonerNameTextbox";
            this.m_summonerNameTextbox.Size = new System.Drawing.Size(227, 26);
            this.m_summonerNameTextbox.TabIndex = 3;
            // 
            // m_addSummoner
            // 
            this.m_addSummoner.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_addSummoner.Location = new System.Drawing.Point(236, 42);
            this.m_addSummoner.Name = "m_addSummoner";
            this.m_addSummoner.Size = new System.Drawing.Size(162, 32);
            this.m_addSummoner.TabIndex = 5;
            this.m_addSummoner.Text = "Add Summoner";
            this.m_addSummoner.UseVisualStyleBackColor = true;
            this.m_addSummoner.Click += new System.EventHandler(this.m_addSummoner_Click);
            // 
            // m_summonersComboBox
            // 
            this.m_summonersComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.m_summonersComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_summonersComboBox.FormattingEnabled = true;
            this.m_summonersComboBox.Location = new System.Drawing.Point(3, 80);
            this.m_summonersComboBox.Name = "m_summonersComboBox";
            this.m_summonersComboBox.Size = new System.Drawing.Size(227, 230);
            this.m_summonersComboBox.TabIndex = 6;
            // 
            // SummonerSelectPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.m_summonersComboBox);
            this.Controls.Add(this.m_addSummoner);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_summonerNameTextbox);
            this.Controls.Add(this.m_startQueryButton);
            this.Name = "SummonerSelectPage";
            this.Size = new System.Drawing.Size(541, 492);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button m_startQueryButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox m_summonerNameTextbox;
        private System.Windows.Forms.Button m_addSummoner;
        private System.Windows.Forms.ComboBox m_summonersComboBox;
    }
}
