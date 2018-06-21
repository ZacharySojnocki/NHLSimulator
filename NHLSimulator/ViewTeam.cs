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
            
            foreach (Team team in Master.NHL.teams)
            {
                cbTeam.Items.Add(team.ToString());
            }
            cbTeam.SelectedIndex = 23;
        }

        private void cbTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTeamName.Text = cbTeam.SelectedItem.ToString();
            team = Master.NHL.teams[cbTeam.SelectedIndex];
            team.roster = team.roster.OrderByDescending(roster => roster.pts).ToList();
            dgvRoster.Rows.Clear();
            foreach(Player player in team.roster)
            {
                String[] row = new String[] { player.ToString(), player.gp.ToString(), player.g.ToString(), player.a.ToString(), player.pts.ToString(), player.pim.ToString(),
                                              player.plusminus.ToString(), player.ppg.ToString(), player.ppp.ToString(), player.shg.ToString(), player.shp.ToString(),
                                              player.gwg.ToString(), player.otg.ToString(), player.s.ToString(), player.shootingPer.ToString() }; 
                dgvRoster.Rows.Add(row);
            }
        }

        private void dgvRoster_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
            if (e.Column.Index != 0)
            {
                e.SortResult = int.Parse(e.CellValue2.ToString()).CompareTo(int.Parse(e.CellValue1.ToString()));
                e.Handled = true;//pass by the default sorting
            }
        }
    }
}
