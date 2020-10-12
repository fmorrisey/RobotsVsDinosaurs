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

        Player player1;
        
        public Battlefield()
        {
            //Instantiate the two groups of dinos and robots
            herdAlpha = new Herd();
            fleetBravo = new Fleet();
            player1 = new Player();
            Menu = new Menu();

        }

        public void RunGame()
        {
            //We will create some kind of loop and menu system
            //First Let's show our robots and dinos to the user
            Menu.Blinker("ALERT!!!", 10, 100);
            Menu.Welcome();
            Menu.DisplayDinoHerd(herdAlpha.herdGroup);
            Menu.DisplayRobotFleet(fleetBravo.fleetGroup);
            
            Menu.Pause();
            

            
            
        }


        

        

    }
}
