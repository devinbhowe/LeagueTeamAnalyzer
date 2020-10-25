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
            this.SuspendLayout();
            // 
            // m_resultsTextbox
            // 
            this.m_resultsTextbox.Enabled = false;
            this.m_resultsTextbox.Location = new System.Drawing.Point(611, 23);
            this.m_resultsTextbox.Name = "m_resultsTextbox";
            this.m_resultsTextbox.Size = new System.Drawing.Size(223, 685);
            this.m_resultsTextbox.TabIndex = 4;
            this.m_resultsTextbox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(608, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Log";
            // 
            // m_Panel
            // 
            this.m_Panel.Location = new System.Drawing.Point(3, 12);
            this.m_Panel.Name = "m_Panel";
            this.m_Panel.Size = new System.Drawing.Size(602, 696);
            this.m_Panel.TabIndex = 8;
            // 
            // DebugAnalyzerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 712);
            this.Controls.Add(this.m_Panel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.m_resultsTextbox);
            this.Name = "DebugAnalyzerUI";
            this.Text = "AnalyzerUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox m_resultsTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel m_Panel;
    }
}