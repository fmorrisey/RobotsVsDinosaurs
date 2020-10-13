﻿using System;
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
        public string Type { get; set; }
        public int Health { get; set; }
        public int Energy { get; set; }
        public string AttackType { get; set; }
        public int AttackPower { get; set; }

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

        public void Attack(Dinosaur dinosaur)
        {
            //This will be called to attack opponent

        }

        public void TakeDamage()
        {
            // this will be called to assign damage to dino
        }

       



    }
}
