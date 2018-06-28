using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHLSimulator
{
    public class Ratings : Player
    {
        //Offence
        int wristShotAcc;
        int wristShotPow;
        int wristShotTen;
        int slapShotAcc;
        int slapShotPow;
        int slapShotTen;
        int snapShotAcc;
        int snapShotPow;
        int snapShotTen;
        int backhandAcc;
        int backhandPow;
        int backhandTen;

        //Defence
        int shotBlocking;
        int stickChecking;
        int pinching;
        int playerCoverage;

        //Puck Skills
        int faceoff;
        int passing;
        int receiving;
        int handEye;
        int stickHandling;
        int puckControl;

        //Positioning 
        int forcheck;
        int backcheck;
        int offensivePos;
        int defensivePos;

        //Skating 
        int acceleration;
        int agility;
        int balance;
        int speed;

        //Physical 
        int tancity;
        int stamina;
        int strength;

        //Mental
        int poise;
        int attitude;
        int discipline;
        int hittingTen;
        int fightingTen;
    }
}
