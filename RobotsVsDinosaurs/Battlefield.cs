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

        Player player1;
        
        public Battlefield()
        {
            //Instantiate the two groups of dinos and robots
            herdAlpha = new Herd();
            fleetBravo = new Fleet();
            player1 = new Player();

        }

        public void RunGame()
        {
            //We will create some kind of loop and menu system
            //First Let's show our robots and dinos to the user
            DisplayDinoHerd(herdAlpha.herdGroup);
            DisplayRobotFleet(fleetBravo.fleetGroup);
            Console.ReadLine();
        }


        public void DisplayDinoHerd(List<Dinosaur> dinosaurs)
        { // This creates and prints a list of Dinos for the player
            Console.WriteLine("DAS DINO HERD!!! \n --------------------");
                       
            for (int i = 0; i < dinosaurs.Count; i++)
            {
                Console.Write($"| {dinosaurs[i].Type} |");
                Console.Write($"{dinosaurs[i].Health} |");
                Console.Write($"{dinosaurs[i].Energy} |");
                Console.Write($"{dinosaurs[i].AttackType} |");
                Console.WriteLine($"{dinosaurs[i].AttackPower} |");
            }
        }


        public void DisplayRobotFleet(List<Robot> robots)
        { // This creates and prints a list of robots for the player
            Console.WriteLine("DER ROBO Fleet!!! \n --------------------");

            for (int i = 0; i < robots.Count; i++)
            {
                Console.Write($"| {robots[i].Name} |");
                Console.Write($"{robots[i].Health} |");
                Console.Write($"{robots[i].PowerLevel} |");
                Console.Write($"{robots[i].Weapon} |");
                Console.WriteLine($"{robots[i].AttackPower} |");
            }
        }

        public void CWshrt()
        {
            void CWBlank()
            {
                Console.WriteLine();
            }
            
            void CWDash()
            {
                Console.WriteLine("----------------");
            }

            void CWStar()
            {
                Console.WriteLine("****************");
            }
        }

    }
}
