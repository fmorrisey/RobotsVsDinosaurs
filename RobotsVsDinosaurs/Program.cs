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
            bool newGame = true;
            bool playAgain = true;
            Menu menu = new Menu();

            while (newGame != false)
            {
                Battlefield battlefield = new Battlefield();
                battlefield.RunGame();
                newGame = menu.PlayAgain(playAgain);
                Console.WriteLine("new game?" , newGame);
                Console.WriteLine("play again?" , playAgain);
                Thread.Sleep(1000);
            }
            Console.WriteLine("Thanks For Playing!!!");
            Console.WriteLine("Winners Don't Do Drugs");
            Console.WriteLine("FBI ANTI-PIRACY WARNING");
            
            
        }
    }
}
