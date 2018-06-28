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
    public partial class EditPlayer : Form
    {
        Team myTeam = new Team();
        public EditPlayer()
        {
            InitializeComponent();
        }

        private void EditPlayer_Load(object sender, EventArgs e)
        {
            foreach (Team team in Master.NHL.teams)
            {
                cbTeam.Items.Add(team.ToString());
            }
            cbTeam.SelectedIndex = 23;
        }

        private void cbTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            myTeam = Master.NHL.teams[cbTeam.SelectedIndex];
            lblTeamName.Text = myTeam.teamName;
            updateListBox();
        }

        private void lstRoster_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        public void updateListBox()
        {
            lstRoster.Items.Clear();
            myTeam.roster = myTeam.roster.OrderBy(roster => roster.lastName).ToList();
            foreach (Player player in myTeam.roster)
                lstRoster.Items.Add(player);
        }
    }
}
