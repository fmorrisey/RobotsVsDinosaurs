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
           // Menu.Blinker("ALERT!!!", 10, 100);
            //Menu.Welcome();

            

            //fleetBravo.fleetGroup.Where(robot => robot.Name == userChoice) //Test the use of Linq to manipulate a sinlge item
            //    .Select(robot => { robot.Health -= hit; return robot; })
            //    .ToList();

            do
            {

                Menu.DisplayDinoHerd(herdAlpha.herdGroup);
                Menu.DisplayRobotFleet(fleetBravo.fleetGroup);
                Menu.Pause();
                fleetBravo.RobotAttack(herdAlpha.herdGroup);
                herdAlpha.DinosaurAttack(fleetBravo.fleetGroup);
                

            } while ((herdAlpha.herdGroup.Count > 0) && (fleetBravo.fleetGroup.Count > 0));


            
            Menu.DisplayDinoHerd(herdAlpha.herdGroup);
            Menu.DisplayRobotFleet(fleetBravo.fleetGroup);
            Console.WriteLine("game over");

            //Loop until all died of winner


            //death check for removal


            


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
        /*
        public void UsePlatform()
        {

            string userInput = "";
            //Product transferProduct = null;

            Console.WriteLine("Welcome to AmAZINGZon - by Guff Benthos");

            while (userInput != "8")
            {
                Menu.GameMenuDisplay();
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        consumer.AskFirstName();
                        break;
                    case "2":
                        consumer.AskLastName();
                        break;
                    case "3":
                        if (transferProduct != null)
                        {
                            consumer.AddToCart(transferProduct);
                            inventory.InventoryUpdate(transferProduct);
                        }
                        else
                        {
                            Console.WriteLine("No Product Selected");
                        }
                        break;
                    case "4": //consumer.CreateReview(); 
                        break;
                    case "5":
                        transferProduct = consumer.ProductSearch(inventory.inventory);
                        break;
                    case "6":
                        consumer.DisplayProductInfo(inventory.inventory);
                        break;
                    case "7":
                        Console.WriteLine("Nothing here bud (View Cart)");
                        break;
                    case "8":
                        Console.WriteLine("Thanks for using the AMAZINGZONE program!");
                        break;
                    default:
                        Console.WriteLine("Whoops! You've entered invalid input.");
                        Console.WriteLine("Please be sure to enter a number between 1 and 8.");
                        break;
                }
            }
        }*/



    }
}
