using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

        int roundCounter;

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
                      
            //----MENU START UP----//
            Menu.Blinker("ALERT!!!", 10, 100);
            Menu.Welcome();

            //SHOWS THE TEAMS AND STARTS THE BATTLE
            
            bool newRound = true;
            roundCounter = 1;

            while (newRound != false)
            {
                //First we do a roster check
                if (herdAlpha.herdGroup.Count <= 0)
                {
                    //When Dino herd = 0
                    Menu.Blinker("ROBOTS WIN", 10, 200);
                    newRound = false;
                    break;
                }
                else if (fleetBravo.fleetGroup.Count <= 0)
                {
                    //When Robot Fleet = 0 
                    Menu.Blinker("DINOS WIN", 10, 200);
                    newRound = false;
                    break;
                }

                Menu.DisplayDinoHerd(herdAlpha.herdGroup); // Displays current teams
                Menu.DisplayRobotFleet(fleetBravo.fleetGroup); //Including their status
                Menu.Pause("Press ENTER to Start Round"); // then allows the user to move on
                Menu.Clear(); // clears the console


                //START NEXT ROUND

                //Second we draw the menu
                Menu.Blinker($" ROUND START! ", 3, 300);
                Menu.MenuDecorators("hash");
                Console.WriteLine($"#### ROUND: {roundCounter} ####");
                Menu.MenuDecorators("hash");

                
                // Finally they attack each other if anyone is still standing
                herdAlpha.DinosaurAttack(fleetBravo.fleetGroup, herdAlpha.herdGroup);
                fleetBravo.RobotAttack(herdAlpha.herdGroup, fleetBravo.fleetGroup);
                roundCounter++;
                
            }
            
            //When a team has no one left standing, it ends the game
            //Shows who's left standing
            Menu.DisplayDinoHerd(herdAlpha.herdGroup);
            Menu.DisplayRobotFleet(fleetBravo.fleetGroup);
            Menu.Pause("Press Enter to End Game");
            Menu.Blinker("FIGHT OVER", 5, 300);
            
        }
    }
}
