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
        public int age, gamePlayed, goals, assists, points, plusminus, penaltyMinutes, shots, hits, faceOffWins, faceOffsTaken, powerPlayGoals, powerPlayPoints, shortHandedGoals, 
                   shortHandedPoints, gameWinningGoals, overtimeGoals;
        public double shootingPer, pointsPerGame;
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

        public void setStats(int gamePlayed, int goals, int assists, int plusminus, int penaltyMinutes, int powerPlayGoals, int powerPlayPoints, int shortHandedGoals, 
                             int shortHandedPoints, int gameWinningGoals, int overtimeGoals, int shots)
        {
            this.gamePlayed = gamePlayed;
            this.goals = goals;
            this.assists = assists;
            points = goals + assists;
            pointsPerGame = Math.Round(((double)points / (double)gamePlayed), 2);
            this.plusminus = plusminus;
            this.penaltyMinutes = penaltyMinutes;
            this.powerPlayGoals = powerPlayGoals;
            this.powerPlayPoints = powerPlayPoints;
            this.shortHandedGoals = shortHandedGoals;
            this.shortHandedPoints = shortHandedPoints;
            this.gameWinningGoals = gameWinningGoals;
            this.overtimeGoals = overtimeGoals;
            this.shots = shots;
            shootingPer = Math.Round(((double) goals / (double) shots), 4) * 100;
        }

        public override String ToString()
        {
            return firstName + " " + lastName;
        }
    }
}
