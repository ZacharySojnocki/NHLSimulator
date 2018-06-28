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
        enum Zone { Home, Center, Away };
        enum Side { Bench, Mid, Other };
        public Game() { }
        public Game(Team homeTeam, Team awayTeam)
        {
            this.homeTeam = homeTeam;
            this.awayTeam = awayTeam;
        }

        public void play()
        {
            bool gameover = false;
            bool whistle = false;
            bool periodEnd = false;
            int myZone = (int)Zone.Center;
            int mySide = (int)Side.Mid;
            for(int period = 0; period < 3; period++)
            {
                faceoff();
                while (!whistle)
                {

                }
            }
            if (!gameover)
            {

            }
            
        }

        public void faceoff()
        {

        }

        public override string ToString()
        {
            return awayTeam + " - " + homeTeam;
        }
    }
}
