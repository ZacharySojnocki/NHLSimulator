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
        public int age, gamesplayed, goals, assists, points, plusminus, pim, shots, hits, fow, fot;
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

        public override String ToString()
        {
            return firstName + " " + lastName;
        }
    }
}
