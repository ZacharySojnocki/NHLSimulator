﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHLSimulator
{
    public class Player
    {
        public String firstName, lastName, pos, team;
        public DateTime birthdate;
        public Stats stats;
        public Player() { }

        public Player(String firstName, String lastName, String pos, String team)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.pos = pos;
            this.team = team;
            stats = new Stats();
        }

        public override String ToString()
        {
            return firstName + " " + lastName;
        }
    }
}
