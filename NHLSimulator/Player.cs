using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHLSimulator
{
    public class Player
    {
        public String firstName, lastName, pos, team;
        public int age, gp, g, a, pts, plusminus, pim, s, hits, fow, fot, ppg, ppp, shg, shp, gwg, otg;
        public double shootingPer;
        public DateTime birthdate;

        public Player() { }

        public Player(String firstName, String lastName, int age, String pos, String team)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.pos = pos;
            this.team = team;
        }

        public void setStats(int gp, int g, int a, int plusminus, int pim, int ppg, int ppp, int shg, int shp, int gwg, int otg, int s)
        {
            this.gp = gp;
            this.g = g;
            this.a = a;
            pts = g + a;
            this.plusminus = plusminus;
            this.pim = pim;
            this.ppg = ppg;
            this.ppp = ppp;
            this.shg = shg;
            this.gwg = gwg;
            this.otg = otg;
            this.s = s;
            shootingPer = Math.Round(((double) g / (double) s), 2);
        }

        public override String ToString()
        {
            return firstName + " " + lastName;
        }
    }
}
