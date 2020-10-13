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
        //These are used for indvidual Dinosaurs
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
            //Instatiate Dino object and assigns values
            this.Type = type;
            this.Health = health;
            this.Energy = energy;
            this.AttackType = attackType;
            this.AttackPower = attackPower;
            this.rand = new Random();
            this.hitPoints = 0;
        }

        //Memeber Methods

        public void Attack(Robot robotVictim, Dinosaur dinoAttacker) // take in robot and dino hit points
        {
            //Determines attackpower
            int hitPoints = DinoAttackHitPoints(dinoAttacker.AttackPower);
            robotVictim.Health -= hitPoints;

            Console.Write($"DINO: {dinoAttacker.Type} | " +
                $"AtkPwr: {dinoAttacker.AttackPower} | " +
                $"Hit:{hitPoints} |");
        }

        public int DinoAttackHitPoints(int attack)
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
