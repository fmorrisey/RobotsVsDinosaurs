using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    // DINOSAURS OBJECTS
    class Dinosaur
    {
        ////Member Variables
        //These are used for individual Dinosaurs
        public string Type;
        public int Health;
        public int Energy;
        public string AttackType;
        public int AttackPower;

        //These are used for hit point calculations
        public Random rand;
        public int hitPoints;
        

        //Constructor
        public Dinosaur(string type, int health, int energy, string attackType, int attackPower)
        {
            //Instantiate Dino object and assigns values
            this.Type = type;
            this.Health = health;
            this.Energy = energy;
            this.AttackType = attackType;
            this.AttackPower = attackPower;

            //Instantiates the hit point calculation tools
            this.rand = new Random();
            this.hitPoints = 0;
        }

        ////Member Methods
        public void Attack(Robot robotVictim, Dinosaur dinoAttacker)
        {   // Sets a Robot victim of a Dino's attack   
            // Determines hitPoints based on Dino's attackPower
            int hitPoints = DinoAttackHitPoints(dinoAttacker.AttackPower);
            robotVictim.Health -= hitPoints; // Then does damage to robot

            // Shows the calculations of the attacker's hitPoints
            Console.Write($"DINO: {dinoAttacker.Type} | " +
                $"AtkPwr: {dinoAttacker.AttackPower} | " +
                $"Hit:{hitPoints} |");
        }

        public int DinoAttackHitPoints(int attack)
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
