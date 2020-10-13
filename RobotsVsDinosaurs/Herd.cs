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
        public List<Dinosaur> herdGroup; // Creates the Dino heard list variable
        // This creates a list of Dino objects called Heard List

        //constructs the herd
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
        {   //The herd hardcoded with information
            CreateHerd("TRex", 100, 10, "Bite", 25);
            CreateHerd("Iguanodone", 100, 10, "Slash", 15);
            CreateHerd("Stegasaurus", 100, 10, "Charge", 21);
        }

        public void DinosaurAttack(List<Robot> robots, List<Dinosaur> dinosaurs)
        {
            int count = 0; 

            if (robots.Count >= herdGroup.Count)
            {   //Compares the fleet to the heard
                count = herdGroup.Count;
            }
            else
            {   //updates the robot count
                count = robots.Count;
            }

            for (int i = 0; i < count; i++)
            {
                //Dino herd attacks Robot Fleet
                herdGroup[i].Attack(robots[i], dinosaurs[i]);
                // DEBUG: Console.Write($"HrdI: {i} |");
                
                //Checks for dead robots
                if (DeathRobo(robots[i]))
                {   //Removes Robot if health is zero
                    robots.Remove(robots[i]);
                }

                //Checks after removal to max count
                if (robots.Count >= herdGroup.Count)
                {
                    count = herdGroup.Count;
                }
                else
                {
                    count = robots.Count;
                }
            }
        }

        public bool DeathRobo(Robot robot)
        {
            bool death = false;
            if (robot.Health > 0) //Health check
            {
                death = false;
            }
            else
            {
                Console.WriteLine();//Announces death!
                Console.WriteLine($"DEAD: {robot.Name}");
                death = true;
            }
            return death;
        }
    }
}
