using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    // ROBOT OBJECTS
    class Robot
    {
        ////Member Variables
        //These are used for indvidual Robots
        public string Name;
        public int Health;
        public int PowerLevel;
        public string Weapon;
        public int AttackPower;

        //These are used for hit point calculationst
        Random rand;
        public int hitPoints;

        //Constructor
        public Robot(string name, int health, int powerLevel, string weapon, int attackPower)
        {
            //Instantiate Robot Objects and assign values
            this.Name = name;
            this.Health = health;
            this.PowerLevel = powerLevel;
            this.Weapon = weapon;
            this.AttackPower = attackPower;
            this.rand = new Random();
            this.hitPoints = 0;


        }

        // MemberMethods

        public void Attack(Dinosaur dinoVictim, Robot robotAttacker) // take in Dino and robot hit points
        {

            //Determines attackpower
            
            int hitPoints = RobotAttackHitPoints(robotAttacker.AttackPower);
            dinoVictim.Health -= hitPoints;
            
            Console.Write($"ROBOT: {robotAttacker.Name} | " +
                $"AtkPwr: {robotAttacker.AttackPower} | " +
                $"Hit:{hitPoints} |");
            
        }
        
        public int RobotAttackHitPoints(int attack)
        {
            //Rand Hit Point Logic
            int lowerInt = rand.Next(5, 8);
            int lowerRng = rand.Next(lowerInt, attack);
            int attackResult = rand.Next(lowerRng, attack);
            Console.Write($"| Lower: {lowerRng} ");
            Console.WriteLine($" | Upper: {attackResult} ");
            return attackResult;
            
        } 




    }
}
