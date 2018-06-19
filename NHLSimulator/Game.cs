using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHLSimulator
{
    public class Game
    {
        public Team homeTeam, awayTeam;
        public String type;

        public Game() { }
        public Game(Team homeTeam, Team awayTeam)
        {
            this.homeTeam = homeTeam;
            this.awayTeam = awayTeam;
        }

        public override string ToString()
        {
            return awayTeam + " - " + homeTeam;
        }
    }
}
