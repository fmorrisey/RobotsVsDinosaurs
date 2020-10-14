using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vars for run Game
            bool newGame = true;
            bool playAgain = true;
            
            //Creates the menu object
            Menu menu = new Menu();

            while (newGame != false)
            {
                //Runs the game
                Battlefield battlefield = new Battlefield();
                battlefield.RunGame();
                //Asks player if they want to play again
                newGame = menu.PlayAgain(playAgain);
                Thread.Sleep(1000);
            }

            //Exit Game
            menu.Clear();
            Console.WriteLine("Created by: Forrest Morrisey // Oct 2020");
            Console.WriteLine("Thanks For Playing!!!");
            Console.WriteLine("Winners Don't Do Drugs");
            Console.WriteLine("FBI ANTI-PIRACY WARNING");
            
            
        }
    }
}
