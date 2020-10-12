using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    // DINOSAURS OBJECTS
    //
    //
    class Dinosaur
    {
        //Member Variables
        public string Type;
        public int Health;
        public int Energy;
        public string AttackType;
        public int AttackPower;

        //Dinosaur dinosaur;
        //This will be used frequently
        //Random rand;

        //Constructor
        public Dinosaur(string type, int health, int energy, string attackType, int attackPower)
        {
            //Instatiate Dino object and assigns values
            this.Type = type;
            this.Health = health;
            this.Energy = energy;
            this.AttackType = attackType;
            this.AttackPower = attackPower;
        }

        //Memeber Methods

        public void Attack()
        {
            //This will be called to attack opponent
        }

        public void TakeDamage()
        {
            // this will be called to assign damage to dino
        }

       



    }
}
