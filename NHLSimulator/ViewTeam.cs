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
    public partial class ViewTeam : Form
    {
        public Team team = new Team();
        public ViewTeam()
        {
            InitializeComponent();
        }

        private void ViewTeam_Load(object sender, EventArgs e)
        {
            cbTeam.Items.Add("Entire League");
            foreach (Team team in Master.NHL.teams)
            {
                cbTeam.Items.Add(team.ToString());
            }
            cbTeam.SelectedIndex = 24;
        }

        private void cbTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvRoster.Rows.Clear();
            lblTeamName.Text = cbTeam.SelectedItem.ToString();
            if (cbTeam.SelectedIndex != 0)
            {
                team = Master.NHL.teams[cbTeam.SelectedIndex - 1];
                team.roster = team.roster.OrderByDescending(roster => roster.stats.points).ToList();
                foreach (Player player in team.roster)
                {
                    /*String[] row = new String[] { player.ToString(), player.team, player.gamePlayed.ToString(), player.goals.ToString(), player.assists.ToString(), player.points.ToString(),
                                                  player.pointsPerGame.ToString(), player.plusminus.ToString(), player.penaltyMinutes.ToString(), player.powerPlayGoals.ToString(),
                                                  player.powerPlayPoints.ToString(), player.shortHandedGoals.ToString(), player.shortHandedPoints.ToString(),
                                                  player.gameWinningGoals.ToString(), player.overtimeGoals.ToString(), player.shots.ToString(), player.shootingPer.ToString() };*/
                    String[] row = new string[] { player.ToString(), player.team, "0", "0", "0", player.stats.points.ToString(), "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" };
                    dgvRoster.Rows.Add(row);
                }
            } else
            {
                Team league = new Team();
                foreach (Team team in Master.NHL.teams)
                {
                    foreach (Player player in team.roster)
                    {
                        league.addPlayer(player);
                    }
                }
                league.roster = league.roster.OrderByDescending(roster => roster.stats.points).ToList();
                foreach (Player player in league.roster)
                {
                    /*String[] row = new String[] { player.ToString(), player.team, player.gamePlayed.ToString(), player.goals.ToString(), player.assists.ToString(), player.points.ToString(),
                                                  player.pointsPerGame.ToString(), player.plusminus.ToString(), player.penaltyMinutes.ToString(), player.powerPlayGoals.ToString(),
                                                  player.powerPlayPoints.ToString(), player.shortHandedGoals.ToString(), player.shortHandedPoints.ToString(),
                                                  player.gameWinningGoals.ToString(), player.overtimeGoals.ToString(), player.shots.ToString(), player.shootingPer.ToString() };*/
                    String[] row = new string[] { player.ToString(), player.team, "0", "0", "0", player.stats.points.ToString(), "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" };
                    dgvRoster.Rows.Add(row);
                }
            }
        }

        private void dgvRoster_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
            if (e.Column.Index >= 2 && e.Column.Index != 6 && e.Column.Index != 16)
            {
                e.SortResult = int.Parse(e.CellValue2.ToString()).CompareTo(int.Parse(e.CellValue1.ToString()));
                e.Handled = true;//pass by the default sorting
            } else if(e.Column.Index >= 2)
            {
                e.SortResult = double.Parse(e.CellValue2.ToString()).CompareTo(double.Parse(e.CellValue1.ToString()));
                e.Handled = true;//pass by the default sorting
            }
        }
    }
}
