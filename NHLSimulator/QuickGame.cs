using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NHLSimulator
{
    public partial class QuickGame : Form
    {

        public Team homeTeam = new Team();
        public Team awayTeam = new Team();

        public QuickGame()
        {
            InitializeComponent();
        }

        private void QuickGame_Load(object sender, EventArgs e)
        {
            foreach(Team team in Master.NHL.teams)
            {
                cbAway.Items.Add(team.ToString());
                cbHome.Items.Add(team.ToString());
            }
            cbAway.SelectedIndex = 23;
            cbHome.SelectedIndex = 26;
        }

        private void cbAway_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstAway.Items.Clear();
            lblAwayTeam.Text = cbAway.SelectedItem.ToString();
            awayTeam = Master.NHL.teams[cbAway.SelectedIndex];
            loadRoster(false);
        }

        private void cbHome_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstHome.Items.Clear();
            lblHomeTeam.Text = cbHome.SelectedItem.ToString();
            homeTeam = Master.NHL.teams[cbHome.SelectedIndex];
            loadRoster(true);
        }
        
        public void loadRoster(bool isHome)
        {
            if (isHome)
            {
                foreach (Player player in homeTeam.roster)
                    lstHome.Items.Add(player);
            } else
            {
                foreach (Player player in awayTeam.roster)
                    lstAway.Items.Add(player);
            }
        }
    }
}
