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
        //These are used for individual Robots
        public string Name;
        public int Health;
        public int PowerLevel;
        public string Weapon;
        public int AttackPower;

        //These are used for hit point calculations
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

            //Instantiates the hit point calculation tools
            this.rand = new Random();
            this.hitPoints = 0;
        }

        //// MemberMethods
        public void Attack(Dinosaur dinoVictim, Robot robotAttacker) 
        {   // Sets a Dino victim of a Robot's attack   
            // Determines hitPoints based on Robot's attackPower
            int hitPoints = RobotAttackHitPoints(robotAttacker.AttackPower);
            dinoVictim.Health -= hitPoints; // Then does damage to Dinosaur

            // Shows the calculations of the attacker's hitPoints
            Console.Write($"ROBOT: {robotAttacker.Name} | " +
                $"AtkPwr: {robotAttacker.AttackPower} | " +
                $"Hit:{hitPoints} |");
            
        }
        
        public int RobotAttackHitPoints(int attack)
        {
            //Rand Hit Point Logic
            int lowerInt = rand.Next(5, 8); //choses a random min
            int lowerRng = rand.Next(lowerInt, attack); //creates the lower range limit
            int attackResult = rand.Next(lowerRng, attack); //determines the hit points
            Console.Write($"| Lower: {lowerRng} "); // generates a message for the developer
            Console.WriteLine($" | Upper: {attackResult} "); //these messages can be disabled
            return attackResult;
            
        } 




    }
}
