using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    // Controls the Dino Herd
    class Herd
    {
        //Mem Vars
        public List<Dinosaur> herdGroup; // Creates the Dino heard list
        // This creates a list of Dino objects called Heard List

        //constructor
        public Herd()
        {
            herdGroup = new List<Dinosaur>(); //This creats the list of Dinosaur objects added to the heard
            PopulateHerd(); //Call to populate the herd with Dino Objs with assigned values
        }

        //creates the individual Dinosaurs to add to the herdGroup list
        public Dinosaur CreateHerd(string type, int health, int energy, string attackType, int attackPower)
        {   
            Dinosaur dinosaur = new Dinosaur(type, health, energy, attackType, attackPower);
            herdGroup.Add(dinosaur);
            return dinosaur;
        }

        public void PopulateHerd()
        {
            CreateHerd("TRex", 10, 10, "Bite", 10);
            CreateHerd("Iguanodone", 10, 10, "Slash", 10);
            CreateHerd("Stegosaurus", 10, 10, "Charge", 10);
        }
    }
}
