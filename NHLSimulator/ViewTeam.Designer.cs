namespace NHLSimulator
{
    partial class ViewTeam
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
            this.cbTeam = new System.Windows.Forms.ComboBox();
            this.lblTeamName = new System.Windows.Forms.Label();
            this.dgvRoster = new System.Windows.Forms.DataGridView();
            this.Player = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GamesPlayed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Goals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Assists = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Points = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlusMinus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PenaltyMinutes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PowerplayGoals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PowerplayPoints = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShortHandedGoals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShortHandedPoints = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GameWinningGoals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.overtimeGoals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shots = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShootingPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoster)).BeginInit();
            this.SuspendLayout();
            // 
            // cbTeam
            // 
            this.cbTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTeam.FormattingEnabled = true;
            this.cbTeam.Location = new System.Drawing.Point(21, 67);
            this.cbTeam.Name = "cbTeam";
            this.cbTeam.Size = new System.Drawing.Size(163, 21);
            this.cbTeam.TabIndex = 1;
            this.cbTeam.Tag = "My Team";
            this.cbTeam.SelectedIndexChanged += new System.EventHandler(this.cbTeam_SelectedIndexChanged);
            // 
            // lblTeamName
            // 
            this.lblTeamName.AutoSize = true;
            this.lblTeamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.lblTeamName.Location = new System.Drawing.Point(13, 20);
            this.lblTeamName.Name = "lblTeamName";
            this.lblTeamName.Size = new System.Drawing.Size(230, 44);
            this.lblTeamName.TabIndex = 2;
            this.lblTeamName.Text = "Team Name";
            // 
            // dgvRoster
            // 
            this.dgvRoster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoster.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Player,
            this.GamesPlayed,
            this.Goals,
            this.Assists,
            this.Points,
            this.PlusMinus,
            this.PenaltyMinutes,
            this.PowerplayGoals,
            this.PowerplayPoints,
            this.ShortHandedGoals,
            this.ShortHandedPoints,
            this.GameWinningGoals,
            this.overtimeGoals,
            this.Shots,
            this.ShootingPercentage});
            this.dgvRoster.Location = new System.Drawing.Point(191, 146);
            this.dgvRoster.Name = "dgvRoster";
            this.dgvRoster.Size = new System.Drawing.Size(917, 481);
            this.dgvRoster.TabIndex = 3;
            this.dgvRoster.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler(this.dgvRoster_SortCompare);
            // 
            // Player
            // 
            this.Player.HeaderText = "Player";
            this.Player.Name = "Player";
            this.Player.ReadOnly = true;
            this.Player.Width = 150;
            // 
            // GamesPlayed
            // 
            this.GamesPlayed.HeaderText = "GP";
            this.GamesPlayed.Name = "GamesPlayed";
            this.GamesPlayed.ReadOnly = true;
            this.GamesPlayed.Width = 50;
            // 
            // Goals
            // 
            this.Goals.HeaderText = "G";
            this.Goals.Name = "Goals";
            this.Goals.ReadOnly = true;
            this.Goals.Width = 50;
            // 
            // Assists
            // 
            this.Assists.HeaderText = "A";
            this.Assists.Name = "Assists";
            this.Assists.ReadOnly = true;
            this.Assists.Width = 50;
            // 
            // Points
            // 
            this.Points.HeaderText = "PTS";
            this.Points.Name = "Points";
            this.Points.ReadOnly = true;
            this.Points.Width = 50;
            // 
            // PlusMinus
            // 
            this.PlusMinus.HeaderText = "+/-";
            this.PlusMinus.Name = "PlusMinus";
            this.PlusMinus.ReadOnly = true;
            this.PlusMinus.Width = 50;
            // 
            // PenaltyMinutes
            // 
            this.PenaltyMinutes.HeaderText = "PIM";
            this.PenaltyMinutes.Name = "PenaltyMinutes";
            this.PenaltyMinutes.ReadOnly = true;
            this.PenaltyMinutes.Width = 50;
            // 
            // PowerplayGoals
            // 
            this.PowerplayGoals.HeaderText = "PPG";
            this.PowerplayGoals.Name = "PowerplayGoals";
            this.PowerplayGoals.ReadOnly = true;
            this.PowerplayGoals.Width = 50;
            // 
            // PowerplayPoints
            // 
            this.PowerplayPoints.HeaderText = "PPP";
            this.PowerplayPoints.Name = "PowerplayPoints";
            this.PowerplayPoints.ReadOnly = true;
            this.PowerplayPoints.Width = 50;
            // 
            // ShortHandedGoals
            // 
            this.ShortHandedGoals.HeaderText = "SHG";
            this.ShortHandedGoals.Name = "ShortHandedGoals";
            this.ShortHandedGoals.ReadOnly = true;
            this.ShortHandedGoals.Width = 50;
            // 
            // ShortHandedPoints
            // 
            this.ShortHandedPoints.HeaderText = "SHP";
            this.ShortHandedPoints.Name = "ShortHandedPoints";
            this.ShortHandedPoints.ReadOnly = true;
            this.ShortHandedPoints.Width = 50;
            // 
            // GameWinningGoals
            // 
            this.GameWinningGoals.HeaderText = "GWG";
            this.GameWinningGoals.Name = "GameWinningGoals";
            this.GameWinningGoals.ReadOnly = true;
            this.GameWinningGoals.Width = 50;
            // 
            // overtimeGoals
            // 
            this.overtimeGoals.HeaderText = "OTG";
            this.overtimeGoals.Name = "overtimeGoals";
            this.overtimeGoals.ReadOnly = true;
            this.overtimeGoals.Width = 50;
            // 
            // Shots
            // 
            this.Shots.HeaderText = "S";
            this.Shots.Name = "Shots";
            this.Shots.ReadOnly = true;
            this.Shots.Width = 50;
            // 
            // ShootingPercentage
            // 
            this.ShootingPercentage.HeaderText = "S%";
            this.ShootingPercentage.Name = "ShootingPercentage";
            this.ShootingPercentage.ReadOnly = true;
            this.ShootingPercentage.Width = 50;
            // 
            // ViewTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 715);
            this.Controls.Add(this.dgvRoster);
            this.Controls.Add(this.lblTeamName);
            this.Controls.Add(this.cbTeam);
            this.Name = "ViewTeam";
            this.Text = "ViewTeam";
            this.Load += new System.EventHandler(this.ViewTeam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTeam;
        private System.Windows.Forms.Label lblTeamName;
        private System.Windows.Forms.DataGridView dgvRoster;
        private System.Windows.Forms.DataGridViewTextBoxColumn Player;
        private System.Windows.Forms.DataGridViewTextBoxColumn GamesPlayed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Goals;
        private System.Windows.Forms.DataGridViewTextBoxColumn Assists;
        private System.Windows.Forms.DataGridViewTextBoxColumn Points;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlusMinus;
        private System.Windows.Forms.DataGridViewTextBoxColumn PenaltyMinutes;
        private System.Windows.Forms.DataGridViewTextBoxColumn PowerplayGoals;
        private System.Windows.Forms.DataGridViewTextBoxColumn PowerplayPoints;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShortHandedGoals;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShortHandedPoints;
        private System.Windows.Forms.DataGridViewTextBoxColumn GameWinningGoals;
        private System.Windows.Forms.DataGridViewTextBoxColumn overtimeGoals;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shots;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShootingPercentage;
    }
}