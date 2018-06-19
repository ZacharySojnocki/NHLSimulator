using NHLSimulator;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NHLSimulator
{
    public partial class Season : Form
    {
        public int scoreHome, scoreAway, tie, awayWins, awayLosses, awayOT, homeWins, homeLosses, homeOT;
        public Boolean overtime, shootout;
        public Random rand = new Random();
        public List<Team> teams = new List<Team>();
        public Queue<Team> teamSchedule = new Queue<Team>();
        public List<Player> teamRoster = new List<Player>();
        public Team myTeam = new Team();
        public Queue<Game> schedule = new Queue<Game>();
        public Stack<Game> finishedGames;

        private void lstPacific_SelectedIndexChanged(object sender, EventArgs e)
        {   
            foreach(Team indexTeam in teams)
            {
                if (lstPacific.SelectedItem != null && lstPacific.SelectedItem.ToString().Contains(indexTeam.ToString()))
                    myTeam = indexTeam;
            }
            lblTeamName.Text = myTeam.ToString();
            addPlayers();
        }

        private void lstCentral_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Team indexTeam in teams)
            {
                if (lstCentral.SelectedItem != null && lstCentral.SelectedItem.ToString().Contains(indexTeam.ToString()))
                    myTeam = indexTeam;
            }
            lblTeamName.Text = myTeam.ToString();
            addPlayers();
        }

        private void lstAtlantic_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Team indexTeam in teams)
            {
                if (lstAtlantic.SelectedItem != null && lstAtlantic.SelectedItem.ToString().Contains(indexTeam.ToString()))
                    myTeam = indexTeam;
            }
            lblTeamName.Text = myTeam.ToString();
            addPlayers();
        }

        private void lstMetropolitan_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Team indexTeam in teams)
            {
                if (lstMetropolitan.SelectedItem != null && lstMetropolitan.SelectedItem.ToString().Contains(indexTeam.ToString()))
                    myTeam = indexTeam;
            }
            lblTeamName.Text = myTeam.ToString();
            addPlayers();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btnAddPlayers_Click(object sender, EventArgs e)
        {
            using (var reader = new StreamReader(@"Players.txt"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    String[] name;
                    name = values[1].Split('\\');
                    name = name[0].Split(' ');
                    for (int x = 2; x < name.Length; x++)
                        name[1] += " " + name[x];
                    Player player = new Player(name[0], name[1], int.Parse(values[2]), values[3], values[4]);
                    foreach(Team team in teams)
                    {
                        if (player.team == team.abbreviation)
                            team.addPlayer(player);
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            using (var reader = new StreamReader(@"Players.txt"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    String[] name;
                    name = values[1].Split('\\');
                    name = name[0].Split(' ');
                    for (int x = 2; x < name.Length; x++)
                        name[1] += " " + name[x];
                    Player player = new Player(name[0], name[1], int.Parse(values[2]), values[3], values[4]);
                    foreach (Team team in teams)
                    {
                        if (player.team == team.abbreviation)
                            team.addPlayer(player);
                    }
                }
            }
            makeSchedule();
            updateListBoxes();
        }     

        public Season()
        {
            InitializeComponent();
        }

        public void reset()
        {
            foreach(Team team in teams)
            {
                team.reset();
            }
            scoreHome = 0;
            scoreAway = 0;
            tie = 0;
            updateListBoxes();
            schedule = new Queue<Game>();
            makeSchedule();
        }

        public Game playGame(Game game)
        {
            Team homeTeam = game.homeTeam;
            Team awayTeam = game.awayTeam;
            overtime = false;
            shootout = false;
            scoreHome = rand.Next(10);
            scoreAway = rand.Next(10);
            if (scoreHome == scoreAway)
            {
                tie = rand.Next(2);
                switch (tie)
                {
                    case (0):
                        overtime = true;
                        tie = rand.Next(2);
                        if (tie == 0)
                            scoreHome++;
                        else
                            scoreAway++;
                        break;
                    case (1):
                        homeTeam.goalsFor += scoreHome;
                        awayTeam.goalsFor += scoreAway;
                        homeTeam.goalsAgainst += scoreAway;
                        awayTeam.goalsAgainst += scoreHome;
                        shootout = true;
                        tie = rand.Next(2);
                        if (tie == 0)
                            scoreHome++;
                        else
                            scoreAway++;
                        break;
                }
            }
            if (!overtime && !shootout)
            {
                if (scoreHome > scoreAway)
                {
                    homeTeam.wins++;
                    awayTeam.losses++;
                    homeTeam.points += 2;
                }
                else
                {
                    awayTeam.wins++;
                    homeTeam.losses++;
                    awayTeam.points += 2;
                }
            }
            else
            {
                if (scoreHome > scoreAway)
                {
                    homeTeam.wins++;
                    awayTeam.OT++;
                    homeTeam.points += 2;
                    awayTeam.points ++;
                }
                else
                {
                    awayTeam.wins++;
                    homeTeam.OT++;
                    awayTeam.points += 2;
                    homeTeam.points++;
                }
            }
            if (!shootout)
            {
                homeTeam.goalsFor += scoreHome;
                awayTeam.goalsFor += scoreAway;
                homeTeam.goalsAgainst += scoreAway;
                awayTeam.goalsAgainst += scoreHome;
            }
            return game;
        }
        private void btnPlay_Click(object sender, EventArgs e)
        {
            int awayTeam = rand.Next(31);
            int homeTeam = rand.Next(31);
            while(awayTeam == homeTeam)
                homeTeam = rand.Next(31);
            Game myGame = playGame(new Game(teams[homeTeam], teams[awayTeam]));
            teams[homeTeam] = myGame.homeTeam;
            teams[awayTeam] = myGame.awayTeam;
            updateListBoxes();
        }

        private void btnPlay82_Click(object sender, EventArgs e)
        {
            reset();
            while (schedule.Count > 0)
                playGame(schedule.Dequeue());
            updateListBoxes();
        }


        public void makeSchedule()
        {
            int total = 0;
            while (total < 10000)
            {
                int index = rand.Next(31);
                if(teams[index].games.Count < 82)
                {
                    int opponent = rand.Next(31);
                    while (opponent == index)
                        opponent = rand.Next(31);
                    if (teams[opponent].games.Count < 82)
                    { 
                        if (teams[index].checkGame(teams[opponent]) && teams[opponent].checkGame(teams[index]))
                        {
                            schedule.Enqueue(new Game(teams[index], teams[opponent]));
                            teams[index].addGame(teams[opponent]);
                            teams[opponent].addGame(teams[index]);
                        }
                    }
                }
                total++;
            }
        }
        public void updateListBoxes()
        {
            lstPacific.Items.Clear();
            lstAtlantic.Items.Clear();
            lstCentral.Items.Clear();
            lstMetropolitan.Items.Clear();
            dgvStandings.Rows.Clear();
            teams = teams.OrderByDescending(team => team.points).ToList();
            int position = 1;
            foreach (Team team in teams)
            {
                Double GFPG = 0;
                Double GAPG = 0;
                if(team.getGamesPlayed() != 0)
                {
                    GFPG = Math.Round((Double)team.goalsFor / (Double)team.getGamesPlayed(), 2);
                    GAPG = Math.Round((Double)team.goalsAgainst / (Double)team.getGamesPlayed(), 2);
                }
                String[] row = new String[] { position.ToString(), team.name, team.getGamesPlayed().ToString(), team.points.ToString(), team.wins.ToString(), team.losses.ToString(), team.OT.ToString(),
                                                team.goalsFor.ToString(), GFPG.ToString(), GAPG.ToString(), team.goalsAgainst.ToString()};
                dgvStandings.Rows.Add(row);
                switch (team.division)
                {
                    case "Pacific":
                        lstPacific.Items.Add(team.getRecord() + " " + team + " " + team.games.Count);
                        break;
                    case "Central":
                        lstCentral.Items.Add(team.getRecord() + " " + team + " " + team.games.Count);
                        break;
                    case "Atlantic":
                        lstAtlantic.Items.Add(team.getRecord() + " " + team + " " + team.games.Count);
                        break;
                    case "Metropolitan":
                        lstMetropolitan.Items.Add(team.getRecord() + " " + team + " " + team.games.Count);
                        break;
                }
                position++;
            }
        }

        public void addPlayers()
        {
            lstRoster.Items.Clear();
            teamRoster = myTeam.roster;
            foreach (Player player in teamRoster)
                lstRoster.Items.Add(player);
        }
    }
}
