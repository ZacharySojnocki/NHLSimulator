using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHLSimulator
{
    public class League
    {
        public String name;
        public List<Team> teams = new List<Team>();

        public League() { }
        public League(String name)
        {
            this.name = name;
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
            teams.Add(new Team("Vegas Golden Knights", "Pacific", "VEG"));
            teams.Add(new Team("Washington Capitals", "Metropolitan", "WSH"));
            teams.Add(new Team("Winnipeg Jets", "Central", "WPG"));
        }
    }
}
