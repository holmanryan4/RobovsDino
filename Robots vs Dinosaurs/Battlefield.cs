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
        public string begin;
        public Herd herd;
        public Fleet fleet;

        //Constructor
        public Battlefield()
        {
            herd = new Herd();
            fleet = new Fleet();
        }
        public void RunGame()//master method 
        {
            for (int i = 0; i < herd.dinos.Count; i++)
            {
                Console.WriteLine("DINO " + herd.dinos[i].dinotype + "  Robot " + fleet.robos[i].robotName);
                Console.WriteLine(herd.dinos[i].dinotype + " is now attacking robot " + fleet.robos[i].robotName);
                fleet.robos[i].health = fleet.robos[i].health - herd.dinos[i].attackPower;
                Console.WriteLine("Successful hit! " + fleet.robos[i].robotName + "s health is now " + fleet.robos[i].health);

            }
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

           // Console.WriteLine("Welcome to the Battlefield!! Ready your fighter" + fighter);


            switch (fighter)
            {
                case "Robot R2r":
                    Console.WriteLine("You have picked:" + fighter + " GET READY TO FIGHT!!!");
                    break;
                case "Robot B2b":
                    Console.WriteLine("You have picked:" + fighter + " GET READY TO FIGHT!!!");
                    break;
                case "Robot Kim":
                    Console.WriteLine("You have picked:" + fighter + " GET READY TO FIGHT!!!");
                    break;
                case "Dino Pete":
                    Console.WriteLine("You have picked:" + fighter + " GET READY TO FIGHT!!!");
                    break;
                case "Dino Don":
                    Console.WriteLine("You have piced:" + fighter + " GET READY TO FIGHT!!!");
                    break;
                case "Dino Car":
                    Console.WriteLine("You have picked:" + fighter + " GET READY TO FIGHT!!!");
                    break;
                default:
                    Console.WriteLine("Not a valid fighter");
                    break;

                
            }
            Console.WriteLine("Hit enter to begin the battle");
            begin = Console.ReadLine();
            Console.WriteLine("Welcome to the Battlefield!! Ready your fighter " + fighter);
            Console.ReadLine();

        }


        //Constructor

        //member methods (Can Do)
 }  }
