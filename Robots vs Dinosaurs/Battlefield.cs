using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs_Dinosaurs
{
    class Battlefield
    {
        //Member variables (Has A)
        public string start;
        public string fighter;


        public void RunGame()//master method 
        {
            //display welcome message
            
            //choose fighters

            //round 1


            // round 2

            //dissplay ending message 
           // Console.WriteLine("Thanks for playing Dino World Take Over")
        }
        public void RobotsvsDinosaurs()
        {
            Console.WriteLine("Hello and Welcome to Dino World Take Over!");
            Console.WriteLine("Hit Enter to Play");
            start = Console.ReadLine();

            Console.Write("Please choose a fighter \n");
            Console.WriteLine("Robot R2r, Robot B2b, Robot Kim, Dino pete, Dino Don, Dino Car");
            string fighter = Console.ReadLine();
            

            

            switch (fighter)
            {
                case "Robot R2r":
                    Console.WriteLine("You have picked:" + fighter);
                    break;
                case "Robot B2b":
                    Console.WriteLine("You have picked:" + fighter);
                    break;
                case "Robot Kim":
                    Console.WriteLine("You have picked:" + fighter);
                    break;
                case "Dino Pete":
                    Console.WriteLine("You have picked:" + fighter);
                    break;
                case "Dino Don":
                    Console.WriteLine("You have piced:" + fighter);
                    break;
                case "Dino Car":
                    Console.WriteLine("You have picked:" + fighter);
                    break;
                default:
                    Console.WriteLine("Not a valid fighter");
                    break;

                
                   
            }
           
            Console.ReadLine();
            
        }
    }

        //Constructor

        //member methods (Can Do)

    
}
