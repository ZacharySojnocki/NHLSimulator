using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NHLSimulator
{
    public class League
    {
        public String leagueName;
        public List<Team> teams = new List<Team>();

        public League() { }
        public League(String name)
        {
            leagueName = name;
        }

        public void createDefaultNHL()
        {
            teams.Add(new Team("Anaheim Ducks", "Pacific", "ANA"));
            teams.Add(new Team("Arizona Coyotes", "Pacific", "ARI"));
            teams.Add(new Team("Boston Bruins", "Atlantic", "BOS"));
            teams.Add(new Team("Buffalo Sabres", "Atlantic", "BUF"));
            teams.Add(new Team("Calgary Flames", "Pacific", "CGY"));
            teams.Add(new Team("Carolina Hurricanes", "Metropolitan", "CAR"));
            teams.Add(new Team("Chicago Blackhawks", "Central", "CHI"));
            teams.Add(new Team("Colorado Avalanche", "Central", "COL"));
            teams.Add(new Team("Columbus Blue Jackets", "Metropolitan", "CBJ"));
            teams.Add(new Team("Dallas Stars", "Central", "DAL"));
            teams.Add(new Team("Detroit Red Wings", "Atlantic", "DET"));
            teams.Add(new Team("Edmonton Oilers", "Pacific", "EDM"));
            teams.Add(new Team("Florida Panthers", "Atlantic", "FLA"));
            teams.Add(new Team("Los Angeles Kings", "Pacific", "LAK"));
            teams.Add(new Team("Minnesota Wild", "Central", "MIN"));
            teams.Add(new Team("Montreal Canadiens", "Atlantic", "MTL"));
            teams.Add(new Team("Nashville Predators", "Central", "NSH"));
            teams.Add(new Team("New Jersey Devils", "Metropolitan", "NJD"));
            teams.Add(new Team("New York Islanders", "Metropolitan", "NYI"));
            teams.Add(new Team("New York Rangers", "Metropolitan", "NYR"));
            teams.Add(new Team("Ottawa Senators", "Atlantic", "OTT"));
            teams.Add(new Team("Philadelphia Flyers", "Metropolitan", "PHI"));
            teams.Add(new Team("Pittsburgh Penguins", "Metropolitan", "PIT"));
            teams.Add(new Team("San Jose Sharks", "Pacific", "SJS"));
            teams.Add(new Team("St. Louis Blues", "Central", "STL"));
            teams.Add(new Team("Tampa Bay Lightning", "Atlantic", "TBL"));
            teams.Add(new Team("Toronto Maple Leafs", "Atlantic", "TOR"));
            teams.Add(new Team("Vancouver Canucks", "Pacific", "VAN"));
            teams.Add(new Team("Vegas Golden Knights", "Pacific", "VGK"));
            teams.Add(new Team("Washington Capitals", "Metropolitan", "WSH"));
            teams.Add(new Team("Winnipeg Jets", "Central", "WPG"));
            //teams.Add(new Team("Ohter", "Test", "TEST"));
            using (var reader = new StreamReader(@"Roster1.csv"))
            {
                for (var i = 0; i < 3; i++)
                {
                    reader.ReadLine();
                }
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();

                    var results = from Match match in Regex.Matches(line, "\"([^\"]*)\"")
                                  select match.ToString();
                    Queue<String> resultsQ = new Queue<string>();
                    foreach (String result in results)
                    {
                        line = line.Replace(result, "XXXXXX");
                        var tempResult = result.Replace("\"", "");
                        resultsQ.Enqueue(tempResult);
                    }
                    var values = line.Split(',');
                    for (int x = 0; x < values.Length; x++)
                    {
                        if (values[x] == "XXXXXX")
                            values[x] = resultsQ.Dequeue();
                    }
                    var teams = values[20].Split(',');
                    Player player = new Player(values[18], values[17], int.Parse(values[12]), values[19], teams[teams.Count() - 1].Trim());
                    player.setStats(int.Parse(values[21]), int.Parse(values[22]), int.Parse(values[23]), int.Parse(values[31]), int.Parse(values[33]), 0, 0, 0, 0,
                                    int.Parse(values[89]), int.Parse(values[87]), int.Parse(values[47]));
                    foreach (Team team in Master.NHL.teams)
                    {
                        if (player.team == team.abbreviation)
                        {
                            team.addPlayer(player);
                            break;
                        }
                        else if (team.abbreviation == "TES")
                        {
                            team.addPlayer(player);
                        }
                    }
                }
            }
        }
    }
}
