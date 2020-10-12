using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

        //Menu menu;

        public Menu()
        {
            herdAlpha = new Herd();
            fleetBravo = new Fleet();
            //menu = new Menu();
            //DisplayDinoHerd(herdAlpha.herdGroup);

        }

        public void Welcome()
        {
            //Welcomes the player to the game

            Console.WriteLine("    THE DINOSAURS ARE ATTACKING!!!");
            Thread.Sleep(1000);
           
            Console.WriteLine("###################################### \n" +
                              "####WELCOME TO ROBOTS VS DINOSAURS#### \n" +
                              "###################################### \n");
            Thread.Sleep(500);
            Console.Write("--Press ENTER to START the Battle!!!--");
            Console.ReadLine();
        }

        public void GameMenu()
        {

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


        public void Next()
        {
            //A console readline that tells user to hit enter for next menu option
            Console.WriteLine("---Press any key for next");
            Console.ReadLine();
        }
        public void Pause()
        {
            //Basicly a CR with text output so the user knows what it's asking for
            Console.WriteLine("press any key to contiunue...");
            Console.ReadLine();
        }
        
        public void Blinker(string text, int blinkNum, int milliseconds)
        {
            //COPIED FROM STACKOVERFLOW https://stackoverflow.com/questions/4755204/adding-line-break
            //Takes in custom text, repeats three times, blinks as much as you like, and at a set interveral

            bool visible = true;
            for (int i = 0; i < blinkNum; i++)
            {
                string alert = visible ? ($"{text} {text} {text}") : "";
                visible = !visible;
                Console.Clear();
                //string details = File.ReadAllText(@"C:\PersonalAssistant\RecentMeetingDetails.txt");
                Console.Write("{0}\n", alert);
                Thread.Sleep(milliseconds);
            }
        }
        
        public void Clear()
        {
            //Clears the menu
            Console.Clear();
        }

        public void Write(string text)
        {
            //This is pointless but a faster writeline method
            //Cause anything goes I guess???
            Console.WriteLine(text);
        }
    }
}
