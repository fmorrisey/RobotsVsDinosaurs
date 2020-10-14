using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    // Controls the Fleet of robots
    class Fleet
    {
        //Member Vars
        public List<Robot> fleetGroup; // Creates the Fleet List
        // This creates a list of robot objects called Fleet List

        //constructs the fleet
        public Fleet()
        {
            fleetGroup = new List<Robot>(); //This creates the list of robots objects added to the heard
            PopulateFleet(); //Calls to populate the fleet with Robot objs to with assigned values
        }

        public void PopulateFleet() //Helper method to create the fleet
        {   //The Robot fleet hardcoded with information
            CreateRobot("Rocky", 100, 10, "Sword", 20);
            CreateRobot("Johnny", 100, 10, "Lazer", 18);
            CreateRobot("Kyle", 100, 10, "Saw", 16);
            
        }
        //Creates the individual Robots to add to the fleetGroup list
        public Robot CreateRobot(string name, int health, int powerLevel, string weapon, int attackPower)
        {
            Robot robot = new Robot(name, health, powerLevel, weapon, attackPower);
            fleetGroup.Add(robot);
            return robot;
        }


        public void RobotAttack(List<Dinosaur> dinosaurs, List<Robot> robots)
        {
            int count = 0;

            // checks to see if there is anyone to attack
            if (dinosaurs.Count >= fleetGroup.Count) 
            {   // Compares the heard to the fleet
                count = fleetGroup.Count;
            }
            else
            {   //updates the dino count
                count = dinosaurs.Count;
            }

            for (int i = 0; i < count; i++)
            {
                //Robot Fleet attack Dino Herd
                fleetGroup[i].Attack(dinosaurs[i], robots[i]);
                // DEBUG: Console.Write($"FltI: {i} |");
                
                //Checks for dead Dino
                if (DeathDino(dinosaurs[i]))
                {   //Removes Dino if health is zero
                    dinosaurs.Remove(dinosaurs[i]);
                }

                //Checks after removal to max count
                if (dinosaurs.Count >= fleetGroup.Count)
                {
                    count = fleetGroup.Count;
                }
                else
                {
                    count = dinosaurs.Count;
                }

            }

            
        }

        public bool DeathDino(Dinosaur dinosaur)
        {
            bool death = false; //Death Bool
            if (dinosaur.Health > 0) //Health check
            {   //You ok buddy?
                death = false;
            }
            else
            {
                Console.WriteLine(); //Announces death!
                Console.WriteLine($"DEAD: {dinosaur.Type}");
                //They were beloved and will be missed
                death = true;
            }
            return death;
        }
    }
}
