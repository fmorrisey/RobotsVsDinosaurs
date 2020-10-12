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
        public Herd herdAlpha;
        public Fleet fleetBravo;
        


        public Battlefield()
        {
            //Instantiate the two groups of dinos and robots
            herdAlpha = new Herd();
            fleetBravo = new Fleet();
            Console.ReadLine();

        }

        public void RunGame()
        {
            //Legacy RunGame Code
            //Robot RockyRobot = new Robot();
            //Robot JohhnyRobot = new Robot();
            //Robot ZemberRobot = new Robot();

            //Dinosaur TerrytRex = new Dinosaur();
            //Dinosaur IggyIguano = new Dinosaur();
            //Dinosaur StanStego = new Dinosaur();

            //We will create some kind of loop and menu system

            foreach (Dinosaur dinosaur in herdAlpha)
            {
                Console.WriteLine(dinosaur);
            }
        }

    }
}
