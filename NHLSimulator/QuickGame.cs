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
            lblAwayTeam.Text = cbAway.SelectedItem.ToString();
            awayTeam = Master.NHL.teams[cbAway.SelectedIndex];
            loadRoster(false);
        }

        private void cbHome_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblHomeTeam.Text = cbHome.SelectedItem.ToString();
            homeTeam = Master.NHL.teams[cbHome.SelectedIndex];
            loadRoster(true);
        }
        
        public void loadRoster(bool isHome)
        {
            if (!isHome)
            {
                lblAwayCenter1.Text = awayTeam.forwardLines[0].center.ToString();
                lblAwayCenter2.Text = awayTeam.forwardLines[1].center.ToString();
                lblAwayCenter3.Text = awayTeam.forwardLines[2].center.ToString();
                lblAwayCenter4.Text = awayTeam.forwardLines[3].center.ToString();
                lblAwayLeftWing1.Text = awayTeam.forwardLines[0].leftWing.ToString();
                lblAwayLeftWing2.Text = awayTeam.forwardLines[1].leftWing.ToString();
                lblAwayLeftWing3.Text = awayTeam.forwardLines[2].leftWing.ToString();
                lblAwayLeftWing4.Text = awayTeam.forwardLines[3].leftWing.ToString();
                lblAwayRightWing1.Text = awayTeam.forwardLines[0].rightWing.ToString();
                lblAwayRightWing2.Text = awayTeam.forwardLines[1].rightWing.ToString();
                lblAwayRightWing3.Text = awayTeam.forwardLines[2].rightWing.ToString();
                lblAwayRightWing4.Text = awayTeam.forwardLines[3].rightWing.ToString();
                lblAwayRightDef1.Text = awayTeam.defenseLines[0].rightDefense.ToString();
                lblAwayRightDef2.Text = awayTeam.defenseLines[1].rightDefense.ToString();
                lblAwayRightDef3.Text = awayTeam.defenseLines[2].rightDefense.ToString();
                lblAwayLeftDef1.Text = awayTeam.defenseLines[0].leftDefense.ToString();
                lblAwayLeftDef2.Text = awayTeam.defenseLines[1].leftDefense.ToString();
                lblAwayLeftDef3.Text = awayTeam.defenseLines[2].leftDefense.ToString();
                lblAwayStarter.Text = awayTeam.goalies[0].ToString();
                lblAwayBackup.Text = awayTeam.goalies[1].ToString();
            } else
            {
                lblHomeCenter1.Text = homeTeam.forwardLines[0].center.ToString();
                lblHomeCenter2.Text = homeTeam.forwardLines[1].center.ToString();
                lblHomeCenter3.Text = homeTeam.forwardLines[2].center.ToString();
                lblHomeCenter4.Text = homeTeam.forwardLines[3].center.ToString();
                lblHomeLeftWing1.Text = homeTeam.forwardLines[0].leftWing.ToString();
                lblHomeLeftWing2.Text = homeTeam.forwardLines[1].leftWing.ToString();
                lblHomeLeftWing3.Text = homeTeam.forwardLines[2].leftWing.ToString();
                lblHomeLeftWing4.Text = homeTeam.forwardLines[3].leftWing.ToString();
                lblHomeRightWing1.Text = homeTeam.forwardLines[0].rightWing.ToString();
                lblHomeRightWing2.Text = homeTeam.forwardLines[1].rightWing.ToString();
                lblHomeRightWing3.Text = homeTeam.forwardLines[2].rightWing.ToString();
                lblHomeRightWing4.Text = homeTeam.forwardLines[3].rightWing.ToString();
                lblHomeRightDef1.Text = homeTeam.defenseLines[0].rightDefense.ToString();
                lblHomeRightDef2.Text = homeTeam.defenseLines[1].rightDefense.ToString();
                lblHomeRightDef3.Text = homeTeam.defenseLines[2].rightDefense.ToString();
                lblHomeLeftDef1.Text = homeTeam.defenseLines[0].leftDefense.ToString();
                lblHomeLeftDef2.Text = homeTeam.defenseLines[1].leftDefense.ToString();
                lblHomeLeftDef3.Text = homeTeam.defenseLines[2].leftDefense.ToString();
                lblHomeStarter.Text = homeTeam.goalies[0].ToString();
                lblHomeBackup.Text = homeTeam.goalies[1].ToString();
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Game game = new Game(homeTeam, awayTeam);
        }
    }
}
