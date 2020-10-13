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

        public void GameMenuDisplay()
        {
            // The "\n" you see in the first and last Console.WriteLine is called an "escape character".
            // It creates a new line in the console, which makes the things printing 
            // to the console look cleaner and more spaced out :)
            Console.WriteLine($"Welcome");
            Console.WriteLine("\nPress [1] for Robot to attack Dino.");
            Console.WriteLine("Press [2] for Dino to attack Robo.");
            Console.WriteLine("Press [3] to add item to cart.");
            Console.WriteLine("Press [4] to to create a review.");
            Console.WriteLine("Press [5] to select a product.");
            Console.WriteLine("Press [6] to display a product.");
            Console.WriteLine("Press [7] ????????(later view cart).");
            Console.WriteLine("Press [8] to exit.\n");
        }

        

        public void GameMenuSelction(string userChoice)
        {
  
            switch (userChoice)
            {
                case "1": /*action*/ break;
                case "2": /*action*/ break;
                case "3": /*action*/ break;
                default: break;
            }

            //return?
        }

        public void DisplayScore(List<Dinosaur> dinosaurs, List<Robot> robots)
        {   //An Attempt to make a table but will require actual table commands and custom classes
            //https://stackoverflow.com/questions/856845/how-to-best-way-to-draw-table-in-console-app-c
            Console.WriteLine("DAS DINO HERD!!!");
            MenuDecorators("dash");

            for (int i = 0; i < dinosaurs.Count; i++)
            {
                //Row 1
                Console.Write($"| {dinosaurs[i].Type} |");
                MenuDecorators("div");
                Console.Write($"| {robots[i].Name} |");

                // Row 2
                Console.Write($"{dinosaurs[i].Health} |");
                MenuDecorators("div");
                Console.Write($"| {robots[i].Health} |");

                // Row 3
                Console.Write($"{dinosaurs[i].Energy} |");
                MenuDecorators("div");
                Console.Write($"| {robots[i].PowerLevel} |");

                // Row 4
                Console.Write($"{dinosaurs[i].AttackType} |");
                MenuDecorators("div");
                Console.Write($"| {robots[i].Weapon} |");

                //Row 5
                Console.WriteLine($"{dinosaurs[i].AttackPower} |");
                MenuDecorators("div");
                Console.Write($"| {robots[i].AttackPower} |");
            }

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
                case "div": Console.Write(" || "); break;
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
