namespace NHLSimulator
{
    partial class Season
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
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPlay82 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lstPacific = new System.Windows.Forms.ListBox();
            this.lstCentral = new System.Windows.Forms.ListBox();
            this.lstAtlantic = new System.Windows.Forms.ListBox();
            this.lstMetropolitan = new System.Windows.Forms.ListBox();
            this.lblTeamName = new System.Windows.Forms.Label();
            this.lstRoster = new System.Windows.Forms.ListBox();
            this.dgvStandings = new System.Windows.Forms.DataGridView();
            this.Place = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Team = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GamesPlayed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Points = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wins = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Losses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OvertimeLosses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoalsFor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoalsForPerGame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoalsAgainst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoalsAgainstPerGame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStandings)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(3, 3);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPlay82
            // 
            this.btnPlay82.Location = new System.Drawing.Point(3, 32);
            this.btnPlay82.Name = "btnPlay82";
            this.btnPlay82.Size = new System.Drawing.Size(75, 23);
            this.btnPlay82.TabIndex = 13;
            this.btnPlay82.Text = "Play 82";
            this.btnPlay82.UseVisualStyleBackColor = true;
            this.btnPlay82.Click += new System.EventHandler(this.btnPlay82_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(3, 61);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lstPacific
            // 
            this.lstPacific.FormattingEnabled = true;
            this.lstPacific.Location = new System.Drawing.Point(1123, 8);
            this.lstPacific.Name = "lstPacific";
            this.lstPacific.Size = new System.Drawing.Size(172, 147);
            this.lstPacific.TabIndex = 15;
            this.lstPacific.SelectedIndexChanged += new System.EventHandler(this.lstPacific_SelectedIndexChanged);
            // 
            // lstCentral
            // 
            this.lstCentral.FormattingEnabled = true;
            this.lstCentral.Location = new System.Drawing.Point(1123, 161);
            this.lstCentral.Name = "lstCentral";
            this.lstCentral.Size = new System.Drawing.Size(172, 147);
            this.lstCentral.TabIndex = 16;
            this.lstCentral.SelectedIndexChanged += new System.EventHandler(this.lstCentral_SelectedIndexChanged);
            // 
            // lstAtlantic
            // 
            this.lstAtlantic.FormattingEnabled = true;
            this.lstAtlantic.Location = new System.Drawing.Point(1123, 375);
            this.lstAtlantic.Name = "lstAtlantic";
            this.lstAtlantic.Size = new System.Drawing.Size(172, 147);
            this.lstAtlantic.TabIndex = 17;
            this.lstAtlantic.SelectedIndexChanged += new System.EventHandler(this.lstAtlantic_SelectedIndexChanged);
            // 
            // lstMetropolitan
            // 
            this.lstMetropolitan.FormattingEnabled = true;
            this.lstMetropolitan.Location = new System.Drawing.Point(1123, 528);
            this.lstMetropolitan.Name = "lstMetropolitan";
            this.lstMetropolitan.Size = new System.Drawing.Size(172, 147);
            this.lstMetropolitan.TabIndex = 18;
            this.lstMetropolitan.SelectedIndexChanged += new System.EventHandler(this.lstMetropolitan_SelectedIndexChanged);
            // 
            // lblTeamName
            // 
            this.lblTeamName.AutoSize = true;
            this.lblTeamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.lblTeamName.Location = new System.Drawing.Point(85, 3);
            this.lblTeamName.Name = "lblTeamName";
            this.lblTeamName.Size = new System.Drawing.Size(0, 44);
            this.lblTeamName.TabIndex = 19;
            // 
            // lstRoster
            // 
            this.lstRoster.FormattingEnabled = true;
            this.lstRoster.Location = new System.Drawing.Point(945, 8);
            this.lstRoster.Name = "lstRoster";
            this.lstRoster.Size = new System.Drawing.Size(172, 667);
            this.lstRoster.TabIndex = 20;
            // 
            // dgvStandings
            // 
            this.dgvStandings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStandings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Place,
            this.Team,
            this.GamesPlayed,
            this.Points,
            this.Wins,
            this.Losses,
            this.OvertimeLosses,
            this.GoalsFor,
            this.GoalsForPerGame,
            this.GoalsAgainst,
            this.GoalsAgainstPerGame});
            this.dgvStandings.Location = new System.Drawing.Point(3, 90);
            this.dgvStandings.Name = "dgvStandings";
            this.dgvStandings.Size = new System.Drawing.Size(936, 585);
            this.dgvStandings.TabIndex = 21;
            // 
            // Place
            // 
            this.Place.HeaderText = "Place";
            this.Place.Name = "Place";
            this.Place.ReadOnly = true;
            this.Place.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Place.Width = 50;
            // 
            // Team
            // 
            this.Team.HeaderText = "Team";
            this.Team.Name = "Team";
            this.Team.ReadOnly = true;
            this.Team.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Team.Width = 150;
            // 
            // GamesPlayed
            // 
            this.GamesPlayed.HeaderText = "GP";
            this.GamesPlayed.Name = "GamesPlayed";
            this.GamesPlayed.ReadOnly = true;
            this.GamesPlayed.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.GamesPlayed.Width = 50;
            // 
            // Points
            // 
            this.Points.HeaderText = "PTS";
            this.Points.Name = "Points";
            this.Points.ReadOnly = true;
            this.Points.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Points.Width = 50;
            // 
            // Wins
            // 
            this.Wins.HeaderText = "W";
            this.Wins.Name = "Wins";
            this.Wins.ReadOnly = true;
            this.Wins.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Wins.Width = 50;
            // 
            // Losses
            // 
            this.Losses.HeaderText = "L";
            this.Losses.Name = "Losses";
            this.Losses.ReadOnly = true;
            this.Losses.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Losses.Width = 50;
            // 
            // OvertimeLosses
            // 
            this.OvertimeLosses.HeaderText = "OTL";
            this.OvertimeLosses.Name = "OvertimeLosses";
            this.OvertimeLosses.ReadOnly = true;
            this.OvertimeLosses.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.OvertimeLosses.Width = 50;
            // 
            // GoalsFor
            // 
            this.GoalsFor.HeaderText = "GF";
            this.GoalsFor.Name = "GoalsFor";
            this.GoalsFor.ReadOnly = true;
            this.GoalsFor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.GoalsFor.Width = 50;
            // 
            // GoalsForPerGame
            // 
            this.GoalsForPerGame.HeaderText = "GFPG";
            this.GoalsForPerGame.Name = "GoalsForPerGame";
            this.GoalsForPerGame.ReadOnly = true;
            this.GoalsForPerGame.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.GoalsForPerGame.Width = 50;
            // 
            // GoalsAgainst
            // 
            this.GoalsAgainst.HeaderText = "GA";
            this.GoalsAgainst.Name = "GoalsAgainst";
            this.GoalsAgainst.ReadOnly = true;
            this.GoalsAgainst.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.GoalsAgainst.Width = 50;
            // 
            // GoalsAgainstPerGame
            // 
            this.GoalsAgainstPerGame.HeaderText = "GAPG";
            this.GoalsAgainstPerGame.Name = "GoalsAgainstPerGame";
            this.GoalsAgainstPerGame.ReadOnly = true;
            this.GoalsAgainstPerGame.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.GoalsAgainstPerGame.Width = 50;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 687);
            this.Controls.Add(this.dgvStandings);
            this.Controls.Add(this.lstRoster);
            this.Controls.Add(this.lblTeamName);
            this.Controls.Add(this.lstMetropolitan);
            this.Controls.Add(this.lstAtlantic);
            this.Controls.Add(this.lstCentral);
            this.Controls.Add(this.lstPacific);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnPlay82);
            this.Controls.Add(this.btnPlay);
            this.Name = "Form1";
            this.Text = "Simulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStandings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnPlay82;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ListBox lstPacific;
        private System.Windows.Forms.ListBox lstCentral;
        private System.Windows.Forms.ListBox lstAtlantic;
        private System.Windows.Forms.ListBox lstMetropolitan;
        private System.Windows.Forms.Label lblTeamName;
        private System.Windows.Forms.ListBox lstRoster;
        private System.Windows.Forms.DataGridView dgvStandings;
        private System.Windows.Forms.DataGridViewTextBoxColumn Place;
        private System.Windows.Forms.DataGridViewTextBoxColumn Team;
        private System.Windows.Forms.DataGridViewTextBoxColumn GamesPlayed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Points;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wins;
        private System.Windows.Forms.DataGridViewTextBoxColumn Losses;
        private System.Windows.Forms.DataGridViewTextBoxColumn OvertimeLosses;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoalsFor;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoalsForPerGame;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoalsAgainst;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoalsAgainstPerGame;
    }
}

