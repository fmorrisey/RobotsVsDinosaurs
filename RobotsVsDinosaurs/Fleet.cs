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
            CreateRobot("Rocky", 10, 10, "Sword", 10);
            CreateRobot("Johnny", 10, 10, "Lazer", 10);
            CreateRobot("Kyle", 10, 10, "Saw", 10);
        }

    }
}
