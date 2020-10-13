using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    // ROBOT OBJECTS
    //
    //

    class Robot
    {
        //Member Variables
        public string Name { get; set; }
        public int Health { get; set; }
        public int PowerLevel { get; set; }
        public string Weapon { get; set; }
        public int AttackPower { get; set; }

        //This will be used frequently
        //Random rand;

        //Constructor
        public Robot(string name, int health, int powerLevel, string weapon, int attackPower)
        {
            //Instantiate Robot Objects and assign values
            this.Name = name;
            this.Health = health;
            this.PowerLevel = powerLevel;
            this.Weapon = weapon;
            this.AttackPower = attackPower;
            
        }

        // MemberMethods

        public void Attack(Dinosaur dinosaurVictim) // take in dino
        {
            dinosaurVictim.Health -= AttackPower;
            
        }

        public void TakeDamage()
        {
            // ths will be called to assign damage to robot
        }


    }
}
