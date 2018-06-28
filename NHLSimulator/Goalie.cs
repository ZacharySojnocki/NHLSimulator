using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHLSimulator
{
    public class Goalie
    {
        public String firstName, lastName, team;
        public DateTime birthdate;
        public GoalieStats stats;
        public Goalie() { }

        public Goalie(String firstName, String lastName, String team)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.team = team;
            stats = new GoalieStats();
        }

        public override String ToString()
        {
            return firstName + " " + lastName;
        }
    }
}
