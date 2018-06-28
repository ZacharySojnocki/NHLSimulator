namespace NHLSimulator
{
    partial class EditPlayer
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
            this.lblTeamName = new System.Windows.Forms.Label();
            this.cbTeam = new System.Windows.Forms.ComboBox();
            this.lstRoster = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblTeamName
            // 
            this.lblTeamName.AutoSize = true;
            this.lblTeamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.lblTeamName.Location = new System.Drawing.Point(12, 9);
            this.lblTeamName.Name = "lblTeamName";
            this.lblTeamName.Size = new System.Drawing.Size(230, 44);
            this.lblTeamName.TabIndex = 4;
            this.lblTeamName.Text = "Team Name";
            // 
            // cbTeam
            // 
            this.cbTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTeam.FormattingEnabled = true;
            this.cbTeam.Location = new System.Drawing.Point(20, 56);
            this.cbTeam.Name = "cbTeam";
            this.cbTeam.Size = new System.Drawing.Size(163, 21);
            this.cbTeam.TabIndex = 3;
            this.cbTeam.Tag = "My Team";
            this.cbTeam.SelectedIndexChanged += new System.EventHandler(this.cbTeam_SelectedIndexChanged);
            // 
            // lstRoster
            // 
            this.lstRoster.FormattingEnabled = true;
            this.lstRoster.Location = new System.Drawing.Point(20, 93);
            this.lstRoster.Name = "lstRoster";
            this.lstRoster.Size = new System.Drawing.Size(163, 576);
            this.lstRoster.TabIndex = 5;
            this.lstRoster.SelectedIndexChanged += new System.EventHandler(this.lstRoster_SelectedIndexChanged);
            // 
            // EditPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 689);
            this.Controls.Add(this.lstRoster);
            this.Controls.Add(this.lblTeamName);
            this.Controls.Add(this.cbTeam);
            this.Name = "EditPlayer";
            this.Text = "EditPlayer";
            this.Load += new System.EventHandler(this.EditPlayer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTeamName;
        private System.Windows.Forms.ComboBox cbTeam;
        private System.Windows.Forms.ListBox lstRoster;
    }
}