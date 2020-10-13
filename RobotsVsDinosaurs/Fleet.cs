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
            fleetGroup = new List<Robot>(); //This creats the list of robots objects added to the heard
            PopulateFleet(); //Calls to populate the fleet with Robot objs to with assigned values
        }

        //Creates the individual Robots to add to the fleetGroup list
        public Robot CreateRobot(string name, int health, int powerLevel, string weapon, int attackPower)
        {
            Robot robot = new Robot(name, health, powerLevel, weapon, attackPower);
            fleetGroup.Add(robot);
            return robot;
        }

        public void PopulateFleet()
        {
            CreateRobot("Rocky", 10, 10, "Sword", 5);
            CreateRobot("Johnny", 10, 10, "Lazer", 3);
            CreateRobot("Kyle", 10, 10, "Saw", 7);
            //Rand for attack power
        }

        public void RobotAttack(List<Dinosaur> dinosaurs)
        {
            int count = 0;

            if (dinosaurs.Count >= fleetGroup.Count)
            {
                count = fleetGroup.Count;
            }
            else
            {
                count = dinosaurs.Count;
            }

            for (int i = 0; i < count; i++)
            {
                //Checks for dead dino
                fleetGroup[i].Attack(dinosaurs[i]);
                if (DeathDino(dinosaurs[i]))
                {
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
            bool death = false;
            if (dinosaur.Health > 0)
            {
                death = false;
            }
            else
            {
                death = true;
            }
            return death;
        }
    }
}
