using NHLSimulator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHLSimulator
{
    public class Team : League
    {
        public String teamName, division, abbreviation, conference;
        public int wins, losses, OT, points, totalDivision, maxDivision, totalConference, maxConference, totalOther, maxOther, goalsFor, goalsAgainst;
        public Queue<Team> games = new Queue<Team>();
        public List<Team> divisionMeetings = new List<Team>();
        public List<Team> conferenceMeetings = new List<Team>();
        public List<Team> otherMeetings = new List<Team>();
        public String[] fiveTime = new String[2];
        public List<Player> roster = new List<Player>();
        public List<Goalie> goalies = new List<Goalie>();
        public List<Line> forwardLines = new List<Line>();
        public List<Line> defenseLines = new List<Line>();
        public Team(){ }

        public Team(String name, String division, String abbreviation)
        {
            this.division = division;
            teamName = name;
            this.abbreviation = abbreviation;
            switch (division)
            {
                case "Metropolitan":
                    maxDivision = 28;
                    maxConference = 24;
                    maxOther = 30;
                    fiveTime[0] = "XXX";
                    fiveTime[1] = "XXX";
                    conference = "East";
                    break;
                case "Atlantic":
                    maxDivision = 28;
                    maxConference = 24;
                    maxOther = 30;
                    fiveTime[0] = "XXX";
                    fiveTime[1] = "XXX";
                    conference = "East";
                    break;
                case "Pacific":
                    maxDivision = 29;
                    maxConference = 21;
                    maxOther = 32;
                    fiveTime[0] = "XXX";
                    conference = "West";
                    break;
                case "Central":
                    maxDivision = 26;
                    maxConference = 24;
                    maxOther = 32;
                    conference = "West";
                    break;
            }
        }

        public String getRecord()
        {
            return wins.ToString() + "-" + losses.ToString() + "-" + OT.ToString();
        }

        public void reset()
        {
            losses = 0;
            OT = 0;
            wins = 0;
            points = 0;
            goalsAgainst = 0;
            goalsFor = 0;
            if (fiveTime[0] != "XXX")
                fiveTime[0] = null;
            if(fiveTime[1] != "XXX")
                fiveTime[1] = null;
            totalConference = 0;
            totalDivision = 0;
            totalOther = 0;
            games = new Queue<Team>();
            divisionMeetings = new List<Team>();
            conferenceMeetings = new List<Team>();
            otherMeetings = new List<Team>();
    }

        public void addGame(Team opponent)
        {
            if (opponent.division == division)
                addGameDivision(opponent);
            else if (opponent.conference == conference)
                addGameConference(opponent);
            else
                addGameOther(opponent);
        }

        public Boolean checkGame(Team opponent)
        {
            if (opponent.division == division)
                return checkGameDivision(opponent);
            else if (opponent.conference == conference)
                return checkGameConference(opponent);
            else
                return checkGameOther(opponent);
        }

        public Boolean checkGameDivision(Team opponent)
        {
            if (!fiveTime.Contains(opponent.teamName))
            {
                for (int x = 0; x < 2; x++)
                {
                    for (int y = 0; y < 2; y++)
                    {
                        if (fiveTime[x] == null && opponent.fiveTime[y] == null)
                        {
                            fiveTime[x] = opponent.teamName;
                            opponent.fiveTime[y] = teamName;
                            return true;
                        }
                    }
                }
            }
            int counter = 0;
            foreach(Team divTeam in divisionMeetings)
            {
                if (divTeam == opponent)
                    counter++;
            }
            if (counter < 4)
                return true;
            else if (counter == 4 && fiveTime.Contains(opponent.teamName))
                return true;
            return false;
        }

        public Boolean checkGameConference(Team opponent)
        {
            int counter = 0;
            foreach (Team conTeam in conferenceMeetings)
            {
                if (conTeam == opponent)
                    counter++;
            }
            if (counter < 3)
                return true;
            return false;
        }
        public Boolean checkGameOther(Team opponent)
        {
            int counter = 0;
            foreach (Team otherTeam in otherMeetings)
            {
                if (otherTeam == opponent)
                    counter++;
            }
            if (counter < 2)
                return true;
            return false;
        }

        public void addGameDivision(Team opponent)
        {
            totalDivision++;
            games.Enqueue(opponent);
            divisionMeetings.Add(opponent);
        }

        public void addGameConference(Team opponent)
        {
            totalConference++;
            games.Enqueue(opponent);
            conferenceMeetings.Add(opponent);
        }

        public void addGameOther(Team opponent)
        {
            totalOther++;
            games.Enqueue(opponent);
            otherMeetings.Add(opponent);
        }

        public override String ToString()
        {
            return teamName;
        }

        public int getGamesPlayed()
        {
            return wins + losses + OT;
        }

        public void addPlayer(Player player)
        {
            roster.Add(player);
        }

        public void addGoalie(Goalie goalie)
        {
            goalies.Add(goalie);
        }
    }
}
