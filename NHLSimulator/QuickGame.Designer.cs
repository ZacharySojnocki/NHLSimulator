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
            this.lblAwayScore = new System.Windows.Forms.Label();
            this.lblHomeScore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblAwayTeam = new System.Windows.Forms.Label();
            this.lblHomeTeam = new System.Windows.Forms.Label();
            this.lblAwayLeftWing1 = new System.Windows.Forms.Label();
            this.lblAwayCenter1 = new System.Windows.Forms.Label();
            this.lblAwayRightWing1 = new System.Windows.Forms.Label();
            this.lblAwayLeftWing2 = new System.Windows.Forms.Label();
            this.lblAwayCenter2 = new System.Windows.Forms.Label();
            this.lblAwayRightWing2 = new System.Windows.Forms.Label();
            this.lblAwayLeftWing3 = new System.Windows.Forms.Label();
            this.lblAwayCenter3 = new System.Windows.Forms.Label();
            this.lblAwayRightWing3 = new System.Windows.Forms.Label();
            this.lblAwayLeftWing4 = new System.Windows.Forms.Label();
            this.lblAwayCenter4 = new System.Windows.Forms.Label();
            this.lblAwayRightWing4 = new System.Windows.Forms.Label();
            this.lblAwayLeftDef1 = new System.Windows.Forms.Label();
            this.lblAwayRightDef1 = new System.Windows.Forms.Label();
            this.lblAwayLeftDef2 = new System.Windows.Forms.Label();
            this.lblAwayRightDef2 = new System.Windows.Forms.Label();
            this.lblAwayLeftDef3 = new System.Windows.Forms.Label();
            this.lblAwayRightDef3 = new System.Windows.Forms.Label();
            this.lblHomeRightDef3 = new System.Windows.Forms.Label();
            this.lblHomeLeftDef3 = new System.Windows.Forms.Label();
            this.lblHomeRightDef2 = new System.Windows.Forms.Label();
            this.lblHomeLeftDef2 = new System.Windows.Forms.Label();
            this.lblHomeRightDef1 = new System.Windows.Forms.Label();
            this.lblHomeLeftDef1 = new System.Windows.Forms.Label();
            this.lblHomeRightWing4 = new System.Windows.Forms.Label();
            this.lblHomeCenter4 = new System.Windows.Forms.Label();
            this.lblHomeLeftWing4 = new System.Windows.Forms.Label();
            this.lblHomeRightWing3 = new System.Windows.Forms.Label();
            this.lblHomeCenter3 = new System.Windows.Forms.Label();
            this.lblHomeLeftWing3 = new System.Windows.Forms.Label();
            this.lblHomeRightWing2 = new System.Windows.Forms.Label();
            this.lblHomeCenter2 = new System.Windows.Forms.Label();
            this.lblHomeLeftWing2 = new System.Windows.Forms.Label();
            this.lblHomeRightWing1 = new System.Windows.Forms.Label();
            this.lblHomeCenter1 = new System.Windows.Forms.Label();
            this.lblHomeLeftWing1 = new System.Windows.Forms.Label();
            this.lblAwayStarter = new System.Windows.Forms.Label();
            this.lblHomeStarter = new System.Windows.Forms.Label();
            this.lblAwayBackup = new System.Windows.Forms.Label();
            this.lblHomeBackup = new System.Windows.Forms.Label();
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
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
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
            // lblAwayLeftWing1
            // 
            this.lblAwayLeftWing1.AutoSize = true;
            this.lblAwayLeftWing1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblAwayLeftWing1.Location = new System.Drawing.Point(81, 203);
            this.lblAwayLeftWing1.Name = "lblAwayLeftWing1";
            this.lblAwayLeftWing1.Size = new System.Drawing.Size(59, 13);
            this.lblAwayLeftWing1.TabIndex = 10;
            this.lblAwayLeftWing1.Text = "John Smith";
            // 
            // lblAwayCenter1
            // 
            this.lblAwayCenter1.AutoSize = true;
            this.lblAwayCenter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblAwayCenter1.Location = new System.Drawing.Point(183, 203);
            this.lblAwayCenter1.Name = "lblAwayCenter1";
            this.lblAwayCenter1.Size = new System.Drawing.Size(59, 13);
            this.lblAwayCenter1.TabIndex = 11;
            this.lblAwayCenter1.Text = "John Smith";
            // 
            // lblAwayRightWing1
            // 
            this.lblAwayRightWing1.AutoSize = true;
            this.lblAwayRightWing1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblAwayRightWing1.Location = new System.Drawing.Point(285, 203);
            this.lblAwayRightWing1.Name = "lblAwayRightWing1";
            this.lblAwayRightWing1.Size = new System.Drawing.Size(59, 13);
            this.lblAwayRightWing1.TabIndex = 12;
            this.lblAwayRightWing1.Text = "John Smith";
            // 
            // lblAwayLeftWing2
            // 
            this.lblAwayLeftWing2.AutoSize = true;
            this.lblAwayLeftWing2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblAwayLeftWing2.Location = new System.Drawing.Point(81, 216);
            this.lblAwayLeftWing2.Name = "lblAwayLeftWing2";
            this.lblAwayLeftWing2.Size = new System.Drawing.Size(59, 13);
            this.lblAwayLeftWing2.TabIndex = 13;
            this.lblAwayLeftWing2.Text = "John Smith";
            // 
            // lblAwayCenter2
            // 
            this.lblAwayCenter2.AutoSize = true;
            this.lblAwayCenter2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblAwayCenter2.Location = new System.Drawing.Point(183, 216);
            this.lblAwayCenter2.Name = "lblAwayCenter2";
            this.lblAwayCenter2.Size = new System.Drawing.Size(59, 13);
            this.lblAwayCenter2.TabIndex = 14;
            this.lblAwayCenter2.Text = "John Smith";
            // 
            // lblAwayRightWing2
            // 
            this.lblAwayRightWing2.AutoSize = true;
            this.lblAwayRightWing2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblAwayRightWing2.Location = new System.Drawing.Point(285, 216);
            this.lblAwayRightWing2.Name = "lblAwayRightWing2";
            this.lblAwayRightWing2.Size = new System.Drawing.Size(59, 13);
            this.lblAwayRightWing2.TabIndex = 15;
            this.lblAwayRightWing2.Text = "John Smith";
            // 
            // lblAwayLeftWing3
            // 
            this.lblAwayLeftWing3.AutoSize = true;
            this.lblAwayLeftWing3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblAwayLeftWing3.Location = new System.Drawing.Point(81, 229);
            this.lblAwayLeftWing3.Name = "lblAwayLeftWing3";
            this.lblAwayLeftWing3.Size = new System.Drawing.Size(59, 13);
            this.lblAwayLeftWing3.TabIndex = 16;
            this.lblAwayLeftWing3.Text = "John Smith";
            // 
            // lblAwayCenter3
            // 
            this.lblAwayCenter3.AutoSize = true;
            this.lblAwayCenter3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblAwayCenter3.Location = new System.Drawing.Point(183, 229);
            this.lblAwayCenter3.Name = "lblAwayCenter3";
            this.lblAwayCenter3.Size = new System.Drawing.Size(59, 13);
            this.lblAwayCenter3.TabIndex = 17;
            this.lblAwayCenter3.Text = "John Smith";
            // 
            // lblAwayRightWing3
            // 
            this.lblAwayRightWing3.AutoSize = true;
            this.lblAwayRightWing3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblAwayRightWing3.Location = new System.Drawing.Point(285, 229);
            this.lblAwayRightWing3.Name = "lblAwayRightWing3";
            this.lblAwayRightWing3.Size = new System.Drawing.Size(59, 13);
            this.lblAwayRightWing3.TabIndex = 18;
            this.lblAwayRightWing3.Text = "John Smith";
            // 
            // lblAwayLeftWing4
            // 
            this.lblAwayLeftWing4.AutoSize = true;
            this.lblAwayLeftWing4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblAwayLeftWing4.Location = new System.Drawing.Point(81, 242);
            this.lblAwayLeftWing4.Name = "lblAwayLeftWing4";
            this.lblAwayLeftWing4.Size = new System.Drawing.Size(59, 13);
            this.lblAwayLeftWing4.TabIndex = 19;
            this.lblAwayLeftWing4.Text = "John Smith";
            // 
            // lblAwayCenter4
            // 
            this.lblAwayCenter4.AutoSize = true;
            this.lblAwayCenter4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblAwayCenter4.Location = new System.Drawing.Point(183, 242);
            this.lblAwayCenter4.Name = "lblAwayCenter4";
            this.lblAwayCenter4.Size = new System.Drawing.Size(59, 13);
            this.lblAwayCenter4.TabIndex = 20;
            this.lblAwayCenter4.Text = "John Smith";
            // 
            // lblAwayRightWing4
            // 
            this.lblAwayRightWing4.AutoSize = true;
            this.lblAwayRightWing4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblAwayRightWing4.Location = new System.Drawing.Point(285, 242);
            this.lblAwayRightWing4.Name = "lblAwayRightWing4";
            this.lblAwayRightWing4.Size = new System.Drawing.Size(59, 13);
            this.lblAwayRightWing4.TabIndex = 21;
            this.lblAwayRightWing4.Text = "John Smith";
            // 
            // lblAwayLeftDef1
            // 
            this.lblAwayLeftDef1.AutoSize = true;
            this.lblAwayLeftDef1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblAwayLeftDef1.Location = new System.Drawing.Point(137, 270);
            this.lblAwayLeftDef1.Name = "lblAwayLeftDef1";
            this.lblAwayLeftDef1.Size = new System.Drawing.Size(59, 13);
            this.lblAwayLeftDef1.TabIndex = 22;
            this.lblAwayLeftDef1.Text = "John Smith";
            // 
            // lblAwayRightDef1
            // 
            this.lblAwayRightDef1.AutoSize = true;
            this.lblAwayRightDef1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblAwayRightDef1.Location = new System.Drawing.Point(239, 270);
            this.lblAwayRightDef1.Name = "lblAwayRightDef1";
            this.lblAwayRightDef1.Size = new System.Drawing.Size(59, 13);
            this.lblAwayRightDef1.TabIndex = 23;
            this.lblAwayRightDef1.Text = "John Smith";
            // 
            // lblAwayLeftDef2
            // 
            this.lblAwayLeftDef2.AutoSize = true;
            this.lblAwayLeftDef2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblAwayLeftDef2.Location = new System.Drawing.Point(137, 283);
            this.lblAwayLeftDef2.Name = "lblAwayLeftDef2";
            this.lblAwayLeftDef2.Size = new System.Drawing.Size(59, 13);
            this.lblAwayLeftDef2.TabIndex = 24;
            this.lblAwayLeftDef2.Text = "John Smith";
            // 
            // lblAwayRightDef2
            // 
            this.lblAwayRightDef2.AutoSize = true;
            this.lblAwayRightDef2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblAwayRightDef2.Location = new System.Drawing.Point(239, 283);
            this.lblAwayRightDef2.Name = "lblAwayRightDef2";
            this.lblAwayRightDef2.Size = new System.Drawing.Size(59, 13);
            this.lblAwayRightDef2.TabIndex = 25;
            this.lblAwayRightDef2.Text = "John Smith";
            // 
            // lblAwayLeftDef3
            // 
            this.lblAwayLeftDef3.AutoSize = true;
            this.lblAwayLeftDef3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblAwayLeftDef3.Location = new System.Drawing.Point(137, 296);
            this.lblAwayLeftDef3.Name = "lblAwayLeftDef3";
            this.lblAwayLeftDef3.Size = new System.Drawing.Size(59, 13);
            this.lblAwayLeftDef3.TabIndex = 26;
            this.lblAwayLeftDef3.Text = "John Smith";
            // 
            // lblAwayRightDef3
            // 
            this.lblAwayRightDef3.AutoSize = true;
            this.lblAwayRightDef3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblAwayRightDef3.Location = new System.Drawing.Point(239, 296);
            this.lblAwayRightDef3.Name = "lblAwayRightDef3";
            this.lblAwayRightDef3.Size = new System.Drawing.Size(59, 13);
            this.lblAwayRightDef3.TabIndex = 27;
            this.lblAwayRightDef3.Text = "John Smith";
            // 
            // lblHomeRightDef3
            // 
            this.lblHomeRightDef3.AutoSize = true;
            this.lblHomeRightDef3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblHomeRightDef3.Location = new System.Drawing.Point(963, 296);
            this.lblHomeRightDef3.Name = "lblHomeRightDef3";
            this.lblHomeRightDef3.Size = new System.Drawing.Size(59, 13);
            this.lblHomeRightDef3.TabIndex = 45;
            this.lblHomeRightDef3.Text = "John Smith";
            // 
            // lblHomeLeftDef3
            // 
            this.lblHomeLeftDef3.AutoSize = true;
            this.lblHomeLeftDef3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblHomeLeftDef3.Location = new System.Drawing.Point(861, 296);
            this.lblHomeLeftDef3.Name = "lblHomeLeftDef3";
            this.lblHomeLeftDef3.Size = new System.Drawing.Size(59, 13);
            this.lblHomeLeftDef3.TabIndex = 44;
            this.lblHomeLeftDef3.Text = "John Smith";
            // 
            // lblHomeRightDef2
            // 
            this.lblHomeRightDef2.AutoSize = true;
            this.lblHomeRightDef2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblHomeRightDef2.Location = new System.Drawing.Point(963, 283);
            this.lblHomeRightDef2.Name = "lblHomeRightDef2";
            this.lblHomeRightDef2.Size = new System.Drawing.Size(59, 13);
            this.lblHomeRightDef2.TabIndex = 43;
            this.lblHomeRightDef2.Text = "John Smith";
            // 
            // lblHomeLeftDef2
            // 
            this.lblHomeLeftDef2.AutoSize = true;
            this.lblHomeLeftDef2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblHomeLeftDef2.Location = new System.Drawing.Point(861, 283);
            this.lblHomeLeftDef2.Name = "lblHomeLeftDef2";
            this.lblHomeLeftDef2.Size = new System.Drawing.Size(59, 13);
            this.lblHomeLeftDef2.TabIndex = 42;
            this.lblHomeLeftDef2.Text = "John Smith";
            // 
            // lblHomeRightDef1
            // 
            this.lblHomeRightDef1.AutoSize = true;
            this.lblHomeRightDef1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblHomeRightDef1.Location = new System.Drawing.Point(963, 270);
            this.lblHomeRightDef1.Name = "lblHomeRightDef1";
            this.lblHomeRightDef1.Size = new System.Drawing.Size(59, 13);
            this.lblHomeRightDef1.TabIndex = 41;
            this.lblHomeRightDef1.Text = "John Smith";
            // 
            // lblHomeLeftDef1
            // 
            this.lblHomeLeftDef1.AutoSize = true;
            this.lblHomeLeftDef1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblHomeLeftDef1.Location = new System.Drawing.Point(861, 270);
            this.lblHomeLeftDef1.Name = "lblHomeLeftDef1";
            this.lblHomeLeftDef1.Size = new System.Drawing.Size(59, 13);
            this.lblHomeLeftDef1.TabIndex = 40;
            this.lblHomeLeftDef1.Text = "John Smith";
            // 
            // lblHomeRightWing4
            // 
            this.lblHomeRightWing4.AutoSize = true;
            this.lblHomeRightWing4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblHomeRightWing4.Location = new System.Drawing.Point(1016, 242);
            this.lblHomeRightWing4.Name = "lblHomeRightWing4";
            this.lblHomeRightWing4.Size = new System.Drawing.Size(59, 13);
            this.lblHomeRightWing4.TabIndex = 39;
            this.lblHomeRightWing4.Text = "John Smith";
            // 
            // lblHomeCenter4
            // 
            this.lblHomeCenter4.AutoSize = true;
            this.lblHomeCenter4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblHomeCenter4.Location = new System.Drawing.Point(914, 242);
            this.lblHomeCenter4.Name = "lblHomeCenter4";
            this.lblHomeCenter4.Size = new System.Drawing.Size(59, 13);
            this.lblHomeCenter4.TabIndex = 38;
            this.lblHomeCenter4.Text = "John Smith";
            // 
            // lblHomeLeftWing4
            // 
            this.lblHomeLeftWing4.AutoSize = true;
            this.lblHomeLeftWing4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblHomeLeftWing4.Location = new System.Drawing.Point(812, 242);
            this.lblHomeLeftWing4.Name = "lblHomeLeftWing4";
            this.lblHomeLeftWing4.Size = new System.Drawing.Size(59, 13);
            this.lblHomeLeftWing4.TabIndex = 37;
            this.lblHomeLeftWing4.Text = "John Smith";
            // 
            // lblHomeRightWing3
            // 
            this.lblHomeRightWing3.AutoSize = true;
            this.lblHomeRightWing3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblHomeRightWing3.Location = new System.Drawing.Point(1016, 229);
            this.lblHomeRightWing3.Name = "lblHomeRightWing3";
            this.lblHomeRightWing3.Size = new System.Drawing.Size(59, 13);
            this.lblHomeRightWing3.TabIndex = 36;
            this.lblHomeRightWing3.Text = "John Smith";
            // 
            // lblHomeCenter3
            // 
            this.lblHomeCenter3.AutoSize = true;
            this.lblHomeCenter3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblHomeCenter3.Location = new System.Drawing.Point(914, 229);
            this.lblHomeCenter3.Name = "lblHomeCenter3";
            this.lblHomeCenter3.Size = new System.Drawing.Size(59, 13);
            this.lblHomeCenter3.TabIndex = 35;
            this.lblHomeCenter3.Text = "John Smith";
            // 
            // lblHomeLeftWing3
            // 
            this.lblHomeLeftWing3.AutoSize = true;
            this.lblHomeLeftWing3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblHomeLeftWing3.Location = new System.Drawing.Point(812, 229);
            this.lblHomeLeftWing3.Name = "lblHomeLeftWing3";
            this.lblHomeLeftWing3.Size = new System.Drawing.Size(59, 13);
            this.lblHomeLeftWing3.TabIndex = 34;
            this.lblHomeLeftWing3.Text = "John Smith";
            // 
            // lblHomeRightWing2
            // 
            this.lblHomeRightWing2.AutoSize = true;
            this.lblHomeRightWing2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblHomeRightWing2.Location = new System.Drawing.Point(1016, 216);
            this.lblHomeRightWing2.Name = "lblHomeRightWing2";
            this.lblHomeRightWing2.Size = new System.Drawing.Size(59, 13);
            this.lblHomeRightWing2.TabIndex = 33;
            this.lblHomeRightWing2.Text = "John Smith";
            // 
            // lblHomeCenter2
            // 
            this.lblHomeCenter2.AutoSize = true;
            this.lblHomeCenter2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblHomeCenter2.Location = new System.Drawing.Point(914, 216);
            this.lblHomeCenter2.Name = "lblHomeCenter2";
            this.lblHomeCenter2.Size = new System.Drawing.Size(59, 13);
            this.lblHomeCenter2.TabIndex = 32;
            this.lblHomeCenter2.Text = "John Smith";
            // 
            // lblHomeLeftWing2
            // 
            this.lblHomeLeftWing2.AutoSize = true;
            this.lblHomeLeftWing2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblHomeLeftWing2.Location = new System.Drawing.Point(812, 216);
            this.lblHomeLeftWing2.Name = "lblHomeLeftWing2";
            this.lblHomeLeftWing2.Size = new System.Drawing.Size(59, 13);
            this.lblHomeLeftWing2.TabIndex = 31;
            this.lblHomeLeftWing2.Text = "John Smith";
            // 
            // lblHomeRightWing1
            // 
            this.lblHomeRightWing1.AutoSize = true;
            this.lblHomeRightWing1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblHomeRightWing1.Location = new System.Drawing.Point(1016, 203);
            this.lblHomeRightWing1.Name = "lblHomeRightWing1";
            this.lblHomeRightWing1.Size = new System.Drawing.Size(59, 13);
            this.lblHomeRightWing1.TabIndex = 30;
            this.lblHomeRightWing1.Text = "John Smith";
            // 
            // lblHomeCenter1
            // 
            this.lblHomeCenter1.AutoSize = true;
            this.lblHomeCenter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblHomeCenter1.Location = new System.Drawing.Point(914, 203);
            this.lblHomeCenter1.Name = "lblHomeCenter1";
            this.lblHomeCenter1.Size = new System.Drawing.Size(59, 13);
            this.lblHomeCenter1.TabIndex = 29;
            this.lblHomeCenter1.Text = "John Smith";
            // 
            // lblHomeLeftWing1
            // 
            this.lblHomeLeftWing1.AutoSize = true;
            this.lblHomeLeftWing1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblHomeLeftWing1.Location = new System.Drawing.Point(812, 203);
            this.lblHomeLeftWing1.Name = "lblHomeLeftWing1";
            this.lblHomeLeftWing1.Size = new System.Drawing.Size(59, 13);
            this.lblHomeLeftWing1.TabIndex = 28;
            this.lblHomeLeftWing1.Text = "John Smith";
            // 
            // lblAwayStarter
            // 
            this.lblAwayStarter.AutoSize = true;
            this.lblAwayStarter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblAwayStarter.Location = new System.Drawing.Point(192, 318);
            this.lblAwayStarter.Name = "lblAwayStarter";
            this.lblAwayStarter.Size = new System.Drawing.Size(59, 13);
            this.lblAwayStarter.TabIndex = 46;
            this.lblAwayStarter.Text = "John Smith";
            // 
            // lblHomeStarter
            // 
            this.lblHomeStarter.AutoSize = true;
            this.lblHomeStarter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblHomeStarter.Location = new System.Drawing.Point(914, 318);
            this.lblHomeStarter.Name = "lblHomeStarter";
            this.lblHomeStarter.Size = new System.Drawing.Size(59, 13);
            this.lblHomeStarter.TabIndex = 47;
            this.lblHomeStarter.Text = "John Smith";
            // 
            // lblAwayBackup
            // 
            this.lblAwayBackup.AutoSize = true;
            this.lblAwayBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblAwayBackup.Location = new System.Drawing.Point(192, 331);
            this.lblAwayBackup.Name = "lblAwayBackup";
            this.lblAwayBackup.Size = new System.Drawing.Size(59, 13);
            this.lblAwayBackup.TabIndex = 48;
            this.lblAwayBackup.Text = "John Smith";
            // 
            // lblHomeBackup
            // 
            this.lblHomeBackup.AutoSize = true;
            this.lblHomeBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblHomeBackup.Location = new System.Drawing.Point(914, 331);
            this.lblHomeBackup.Name = "lblHomeBackup";
            this.lblHomeBackup.Size = new System.Drawing.Size(59, 13);
            this.lblHomeBackup.TabIndex = 49;
            this.lblHomeBackup.Text = "John Smith";
            // 
            // QuickGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 639);
            this.Controls.Add(this.lblHomeBackup);
            this.Controls.Add(this.lblAwayBackup);
            this.Controls.Add(this.lblHomeStarter);
            this.Controls.Add(this.lblAwayStarter);
            this.Controls.Add(this.lblHomeRightDef3);
            this.Controls.Add(this.lblHomeLeftDef3);
            this.Controls.Add(this.lblHomeRightDef2);
            this.Controls.Add(this.lblHomeLeftDef2);
            this.Controls.Add(this.lblHomeRightDef1);
            this.Controls.Add(this.lblHomeLeftDef1);
            this.Controls.Add(this.lblHomeRightWing4);
            this.Controls.Add(this.lblHomeCenter4);
            this.Controls.Add(this.lblHomeLeftWing4);
            this.Controls.Add(this.lblHomeRightWing3);
            this.Controls.Add(this.lblHomeCenter3);
            this.Controls.Add(this.lblHomeLeftWing3);
            this.Controls.Add(this.lblHomeRightWing2);
            this.Controls.Add(this.lblHomeCenter2);
            this.Controls.Add(this.lblHomeLeftWing2);
            this.Controls.Add(this.lblHomeRightWing1);
            this.Controls.Add(this.lblHomeCenter1);
            this.Controls.Add(this.lblHomeLeftWing1);
            this.Controls.Add(this.lblAwayRightDef3);
            this.Controls.Add(this.lblAwayLeftDef3);
            this.Controls.Add(this.lblAwayRightDef2);
            this.Controls.Add(this.lblAwayLeftDef2);
            this.Controls.Add(this.lblAwayRightDef1);
            this.Controls.Add(this.lblAwayLeftDef1);
            this.Controls.Add(this.lblAwayRightWing4);
            this.Controls.Add(this.lblAwayCenter4);
            this.Controls.Add(this.lblAwayLeftWing4);
            this.Controls.Add(this.lblAwayRightWing3);
            this.Controls.Add(this.lblAwayCenter3);
            this.Controls.Add(this.lblAwayLeftWing3);
            this.Controls.Add(this.lblAwayRightWing2);
            this.Controls.Add(this.lblAwayCenter2);
            this.Controls.Add(this.lblAwayLeftWing2);
            this.Controls.Add(this.lblAwayRightWing1);
            this.Controls.Add(this.lblAwayCenter1);
            this.Controls.Add(this.lblAwayLeftWing1);
            this.Controls.Add(this.lblHomeTeam);
            this.Controls.Add(this.lblAwayTeam);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHomeScore);
            this.Controls.Add(this.lblAwayScore);
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
        private System.Windows.Forms.Label lblAwayScore;
        private System.Windows.Forms.Label lblHomeScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblAwayTeam;
        private System.Windows.Forms.Label lblHomeTeam;
        private System.Windows.Forms.Label lblAwayLeftWing1;
        private System.Windows.Forms.Label lblAwayCenter1;
        private System.Windows.Forms.Label lblAwayRightWing1;
        private System.Windows.Forms.Label lblAwayLeftWing2;
        private System.Windows.Forms.Label lblAwayCenter2;
        private System.Windows.Forms.Label lblAwayRightWing2;
        private System.Windows.Forms.Label lblAwayLeftWing3;
        private System.Windows.Forms.Label lblAwayCenter3;
        private System.Windows.Forms.Label lblAwayRightWing3;
        private System.Windows.Forms.Label lblAwayLeftWing4;
        private System.Windows.Forms.Label lblAwayCenter4;
        private System.Windows.Forms.Label lblAwayRightWing4;
        private System.Windows.Forms.Label lblAwayLeftDef1;
        private System.Windows.Forms.Label lblAwayRightDef1;
        private System.Windows.Forms.Label lblAwayLeftDef2;
        private System.Windows.Forms.Label lblAwayRightDef2;
        private System.Windows.Forms.Label lblAwayLeftDef3;
        private System.Windows.Forms.Label lblAwayRightDef3;
        private System.Windows.Forms.Label lblHomeRightDef3;
        private System.Windows.Forms.Label lblHomeLeftDef3;
        private System.Windows.Forms.Label lblHomeRightDef2;
        private System.Windows.Forms.Label lblHomeLeftDef2;
        private System.Windows.Forms.Label lblHomeRightDef1;
        private System.Windows.Forms.Label lblHomeLeftDef1;
        private System.Windows.Forms.Label lblHomeRightWing4;
        private System.Windows.Forms.Label lblHomeCenter4;
        private System.Windows.Forms.Label lblHomeLeftWing4;
        private System.Windows.Forms.Label lblHomeRightWing3;
        private System.Windows.Forms.Label lblHomeCenter3;
        private System.Windows.Forms.Label lblHomeLeftWing3;
        private System.Windows.Forms.Label lblHomeRightWing2;
        private System.Windows.Forms.Label lblHomeCenter2;
        private System.Windows.Forms.Label lblHomeLeftWing2;
        private System.Windows.Forms.Label lblHomeRightWing1;
        private System.Windows.Forms.Label lblHomeCenter1;
        private System.Windows.Forms.Label lblHomeLeftWing1;
        private System.Windows.Forms.Label lblAwayStarter;
        private System.Windows.Forms.Label lblHomeStarter;
        private System.Windows.Forms.Label lblAwayBackup;
        private System.Windows.Forms.Label lblHomeBackup;
    }
}