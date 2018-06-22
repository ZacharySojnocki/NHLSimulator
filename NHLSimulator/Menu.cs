using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NHLSimulator
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            Master.NHL = new League("NHL");
            Master.NHL.createDefaultNHL();
        }

        private void btnPlayOne_Click(object sender, EventArgs e)
        {
            QuickGame quickGame = new QuickGame();
            quickGame.ShowDialog();
            Close();
        }

        private void btnPlay82_Click(object sender, EventArgs e)
        {
            Season season = new Season();
            season.ShowDialog();
            Close();
        }

        private void btnViewTeams_Click(object sender, EventArgs e)
        {
            ViewTeam viewTeam = new ViewTeam();
            viewTeam.ShowDialog();
            Close();
        }

        private void btnEditPlayer_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
