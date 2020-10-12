using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    //This Class is focused on menus for the player to interact with
    class Menu
    {
        public Herd herdAlpha; // Creates the Dino Herd
        public Fleet fleetBravo; // Creates the Robot Fleet
        Dinosaur dinosaur; //Brings the Dino obj to the Battlefield
        Robot robot; //Brings the Robot obj to the battlefield

        public Menu()
        {
            herdAlpha = new Herd();
            fleetBravo = new Fleet();
            

        }

        public void DisplayDinoHerd(List<Dinosaur> dinosaurs)
        { // This creates and prints a list of Dinos for the player
            Console.WriteLine("DAS DINO HERD!!!");
            MenuDecorators("dash");

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
            Console.WriteLine("DER ROBO Fleet!!!");
            MenuDecorators("dash");
            
            for (int i = 0; i < robots.Count; i++)
            {
                Console.Write($"| {robots[i].Name} |");
                Console.Write($"{robots[i].Health} |");
                Console.Write($"{robots[i].PowerLevel} |");
                Console.Write($"{robots[i].Weapon} |");
                Console.WriteLine($"{robots[i].AttackPower} |");
            }
        }


        public void MenuDecorators(string Decoration)
        { // call using the options to decorate the menues!
            string parameterconvert = Decoration.ToLower();
            switch (parameterconvert)
            {
                case "star": Console.WriteLine("***************");break;
                case "dash": Console.WriteLine("---------------");break;
                case "plus": Console.WriteLine("+++++++++++++++"); break;
                case "equal": Console.WriteLine("==============="); break;
                case "slashrt": Console.WriteLine("///////////////"); break;
                case "slashlf": Console.WriteLine("\\\\\\\\\\\\\\\\"); break;
                case "pipe": Console.WriteLine("|||||||||||||||||||"); break;
                default: Console.WriteLine("/In/Valid//Menu//Decorator/"); break;
            }
            
            
        }
    }
}
