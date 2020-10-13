using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Battlefield
    {
        //Spawn Dinos and Robots // Later iterations will have automatd spawner
        public Herd herdAlpha; // Creates the Dino Herd
        public Fleet fleetBravo; // Creates the Robot Fleet
        Dinosaur dinosaur; //Brings the Dino obj to the Battlefield
        Robot robot; //Brings the Robot obj to the battlefield
        Menu Menu;
        List<Dinosaur> herdGroup;
        List<Robot> fleetGroup;

        Player player1;
        
        public Battlefield()
        {
            //Instantiate the two groups of dinos and robots
            herdAlpha = new Herd(); //
            fleetBravo = new Fleet();
            player1 = new Player();
            Menu = new Menu();

        }

        public void RunGame()
        {
            //We will create some kind of loop and menu system
            //First Let's show our robots and dinos to the user
            //HitTransfer = null;


            //----MENU START UP----//
            //Menu.Blinker("ALERT!!!", 10, 100);
            //Menu.Welcome();
            //Menu.DisplayDinoHerd(herdAlpha.herdGroup);

            int hit = 5;
            //robot.Attack(fleetBravo.fleetGroup);

            //var fleetBravoArray = (from r in fleetGroup select r.Name).ToArray();

            string userChoice = "Rocky";

            Menu.DisplayRobotFleet(fleetBravo.fleetGroup);//inital list
            fleetBravo.fleetGroup.Where(robot => robot.Name == userChoice) //Test the use of Linq to manipulate a sinlge item
                .Select(robot => { robot.Health -= hit; return robot; })
                .ToList();

            /*var roboName = fleetBravo.fleetGroup
                .Select(r => { r.Name; return robot; });*/

            //Console.WriteLine(fleetBravoArray);
            

            //var roboName = (from r )



            //name = fleetBravo.fleetGroup.Select(robot => { robot = robot.Name; return name; });
            //Console.WriteLine($"We HIT {name)} W A ROCKET ");
            Menu.DisplayRobotFleet(fleetBravo.fleetGroup); //Prints the list again to check for value
            //Console.WriteLine(robot.Name);
            Menu.Pause();

            //dinosaur.TakeDamage(dinosaur.AttackPower);
            //robot.Health = dinosaur.AttackPower;
            //fleetBravo.fleetGroup.ForEach();

            //List<Robot> robots = fleetBravo.Select()

        }

        //public Robot Attack(List<Robot> robot)
        //{
        //    string userChoice = Console.ReadLine();
        //    Console.WriteLine(robot);

        //    for (int i = 0; i < robot.Count; i++)
        //    {
        //        if (robot)
        //        {

        //        }
        //    }
        //}
        

        

    }
}
