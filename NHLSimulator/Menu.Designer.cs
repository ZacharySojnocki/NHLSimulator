namespace NHLSimulator
{
    partial class Menu
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
            this.btnPlayOne = new System.Windows.Forms.Button();
            this.btnPlay82 = new System.Windows.Forms.Button();
            this.btnViewTeams = new System.Windows.Forms.Button();
            this.btnEditPlayer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPlayOne
            // 
            this.btnPlayOne.Location = new System.Drawing.Point(54, 147);
            this.btnPlayOne.Name = "btnPlayOne";
            this.btnPlayOne.Size = new System.Drawing.Size(143, 137);
            this.btnPlayOne.TabIndex = 0;
            this.btnPlayOne.Text = "Play 1";
            this.btnPlayOne.UseVisualStyleBackColor = true;
            this.btnPlayOne.Click += new System.EventHandler(this.btnPlayOne_Click);
            // 
            // btnPlay82
            // 
            this.btnPlay82.Location = new System.Drawing.Point(234, 147);
            this.btnPlay82.Name = "btnPlay82";
            this.btnPlay82.Size = new System.Drawing.Size(143, 137);
            this.btnPlay82.TabIndex = 1;
            this.btnPlay82.Text = "Play 82";
            this.btnPlay82.UseVisualStyleBackColor = true;
            this.btnPlay82.Click += new System.EventHandler(this.btnPlay82_Click);
            // 
            // btnViewTeams
            // 
            this.btnViewTeams.Location = new System.Drawing.Point(416, 147);
            this.btnViewTeams.Name = "btnViewTeams";
            this.btnViewTeams.Size = new System.Drawing.Size(143, 137);
            this.btnViewTeams.TabIndex = 2;
            this.btnViewTeams.Text = "View Teams";
            this.btnViewTeams.UseVisualStyleBackColor = true;
            this.btnViewTeams.Click += new System.EventHandler(this.btnViewTeams_Click);
            // 
            // btnEditPlayer
            // 
            this.btnEditPlayer.Location = new System.Drawing.Point(598, 147);
            this.btnEditPlayer.Name = "btnEditPlayer";
            this.btnEditPlayer.Size = new System.Drawing.Size(143, 137);
            this.btnEditPlayer.TabIndex = 3;
            this.btnEditPlayer.Text = "Edit Player";
            this.btnEditPlayer.UseVisualStyleBackColor = true;
            this.btnEditPlayer.Click += new System.EventHandler(this.btnEditPlayer_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEditPlayer);
            this.Controls.Add(this.btnViewTeams);
            this.Controls.Add(this.btnPlay82);
            this.Controls.Add(this.btnPlayOne);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPlayOne;
        private System.Windows.Forms.Button btnPlay82;
        private System.Windows.Forms.Button btnViewTeams;
        private System.Windows.Forms.Button btnEditPlayer;
    }
}