namespace NHLSimulator
{
    partial class QuickGame
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
            this.cbAway = new System.Windows.Forms.ComboBox();
            this.cbHome = new System.Windows.Forms.ComboBox();
            this.lstAway = new System.Windows.Forms.ListBox();
            this.lstHome = new System.Windows.Forms.ListBox();
            this.lblAwayScore = new System.Windows.Forms.Label();
            this.lblHomeScore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblAwayTeam = new System.Windows.Forms.Label();
            this.lblHomeTeam = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbAway
            // 
            this.cbAway.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAway.FormattingEnabled = true;
            this.cbAway.Location = new System.Drawing.Point(229, 60);
            this.cbAway.Name = "cbAway";
            this.cbAway.Size = new System.Drawing.Size(163, 21);
            this.cbAway.TabIndex = 0;
            this.cbAway.Tag = "Away Team";
            this.cbAway.SelectedIndexChanged += new System.EventHandler(this.cbAway_SelectedIndexChanged);
            // 
            // cbHome
            // 
            this.cbHome.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHome.FormattingEnabled = true;
            this.cbHome.Location = new System.Drawing.Point(786, 60);
            this.cbHome.Name = "cbHome";
            this.cbHome.Size = new System.Drawing.Size(163, 21);
            this.cbHome.TabIndex = 1;
            this.cbHome.Tag = "Home Team";
            this.cbHome.SelectedIndexChanged += new System.EventHandler(this.cbHome_SelectedIndexChanged);
            // 
            // lstAway
            // 
            this.lstAway.FormattingEnabled = true;
            this.lstAway.Location = new System.Drawing.Point(54, 141);
            this.lstAway.Name = "lstAway";
            this.lstAway.Size = new System.Drawing.Size(152, 303);
            this.lstAway.TabIndex = 2;
            // 
            // lstHome
            // 
            this.lstHome.FormattingEnabled = true;
            this.lstHome.Location = new System.Drawing.Point(968, 141);
            this.lstHome.Name = "lstHome";
            this.lstHome.Size = new System.Drawing.Size(152, 303);
            this.lstHome.TabIndex = 3;
            // 
            // lblAwayScore
            // 
            this.lblAwayScore.AutoSize = true;
            this.lblAwayScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.lblAwayScore.Location = new System.Drawing.Point(482, 226);
            this.lblAwayScore.Name = "lblAwayScore";
            this.lblAwayScore.Size = new System.Drawing.Size(41, 44);
            this.lblAwayScore.TabIndex = 4;
            this.lblAwayScore.Text = "0";
            // 
            // lblHomeScore
            // 
            this.lblHomeScore.AutoSize = true;
            this.lblHomeScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.lblHomeScore.Location = new System.Drawing.Point(628, 226);
            this.lblHomeScore.Name = "lblHomeScore";
            this.lblHomeScore.Size = new System.Drawing.Size(41, 44);
            this.lblHomeScore.TabIndex = 5;
            this.lblHomeScore.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.label1.Location = new System.Drawing.Point(559, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 44);
            this.label1.TabIndex = 6;
            this.label1.Text = "-";
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(481, 409);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(190, 91);
            this.btnPlay.TabIndex = 7;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            // 
            // lblAwayTeam
            // 
            this.lblAwayTeam.AutoSize = true;
            this.lblAwayTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.lblAwayTeam.Location = new System.Drawing.Point(165, 84);
            this.lblAwayTeam.Name = "lblAwayTeam";
            this.lblAwayTeam.Size = new System.Drawing.Size(41, 44);
            this.lblAwayTeam.TabIndex = 8;
            this.lblAwayTeam.Text = "0";
            // 
            // lblHomeTeam
            // 
            this.lblHomeTeam.AutoSize = true;
            this.lblHomeTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.lblHomeTeam.Location = new System.Drawing.Point(723, 84);
            this.lblHomeTeam.Name = "lblHomeTeam";
            this.lblHomeTeam.Size = new System.Drawing.Size(41, 44);
            this.lblHomeTeam.TabIndex = 9;
            this.lblHomeTeam.Text = "0";
            // 
            // QuickGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 639);
            this.Controls.Add(this.lblHomeTeam);
            this.Controls.Add(this.lblAwayTeam);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHomeScore);
            this.Controls.Add(this.lblAwayScore);
            this.Controls.Add(this.lstHome);
            this.Controls.Add(this.lstAway);
            this.Controls.Add(this.cbHome);
            this.Controls.Add(this.cbAway);
            this.Name = "QuickGame";
            this.Text = "QuickGame";
            this.Load += new System.EventHandler(this.QuickGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbAway;
        private System.Windows.Forms.ComboBox cbHome;
        private System.Windows.Forms.ListBox lstAway;
        private System.Windows.Forms.ListBox lstHome;
        private System.Windows.Forms.Label lblAwayScore;
        private System.Windows.Forms.Label lblHomeScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblAwayTeam;
        private System.Windows.Forms.Label lblHomeTeam;
    }
}