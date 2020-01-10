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
        public Herd herd;
        public Fleet fleet;

        //Constructor
        public Battlefield()
        {
            herd = new Herd();
            fleet = new Fleet();
        }

        //member methods (Can Do)
        public void RunGame()//master method 
        {
            //display welcome message
            Console.WriteLine("Hello and Welcome to Dino World Take Over!");
            Console.WriteLine("Hit Enter to Play");
            start = Console.ReadLine();
            Console.WriteLine("Hello player! The Dino herd has taken over and it is up to YOU and your fleet of robos to stop the herd. ");
            Console.ReadLine();
            Console.WriteLine("Good Luck and take no prisoners!");
            Console.ReadLine();
            Console.WriteLine("You and your fleet have just landed in the battlefield hit enter to attack the Dinos!");
            Console.ReadLine();
            // do another for loop to asign weapons to robos//
            for (int i = 0; i < herd.dinos.Count; i++)
            {
                Console.WriteLine("Dino " + herd.dinos[i].dinotype + " vs Robot " + fleet.robos[i].robotName);
                Console.WriteLine(herd.dinos[i].dinotype + " is now attacking robot " + fleet.robos[i].robotName);
                
                fleet.robos[i].health = fleet.robos[i].health - herd.dinos[i].attackPower;
                Console.ReadLine();

                Console.WriteLine("Successful hit! " + fleet.robos[i].robotName + "'s health is now " + fleet.robos[i].health);
                Console.ReadLine();
                Console.WriteLine("Robot " + fleet.robos[i].robotName + " vs Dino " + herd.dinos[i].dinotype);
                Console.ReadLine();
                Console.WriteLine(fleet.robos[i].robotName + " is now attacking dino  " + herd.dinos[i].dinotype + " with " + fleet.robos[i].tools.weapontype);
               
                herd.dinos[i].dinoHealth = herd.dinos[i].dinoHealth - fleet.robos[i].weaponAttackPower;
                Console.ReadLine();
                Console.WriteLine("Successful hit! " + herd.dinos[i].dinotype + "'s health is now " + herd.dinos[i].dinoHealth);
                Console.ReadLine();
                Console.WriteLine("Dino " + herd.dinos[i].dinotype + " vs Robot " + fleet.robos[i].robotName);
                Console.WriteLine(herd.dinos[i].dinotype + " is now attacking robot " + fleet.robos[i].robotName);
                
                fleet.robos[i].health = fleet.robos[i].health;
                Console.ReadLine();
                Console.WriteLine("Hit unsuccrssful! " + fleet.robos[i].robotName + "'s health is " + fleet.robos[i].health);
                Console.ReadLine();
                Console.WriteLine("Robot " + fleet.robos[i].robotName + " vs Dino " + herd.dinos[i].dinotype);
                Console.WriteLine(fleet.robos[i].robotName + " is now attacking dino  " + herd.dinos[i].dinotype + " with sword");
              
                herd.dinos[i].dinoHealth = herd.dinos[i].dinoHealth - fleet.robos[i].weaponAttackPower;
                Console.ReadLine();
                Console.WriteLine("Successful hit! " + herd.dinos[i].dinotype + "'s health is now " + herd.dinos[i].dinoHealth);
                Console.ReadLine();

            }

            //dissplay ending message 
            Console.WriteLine(" GREAT JOB!!  You have defeated The Dinosaurs Herd!");
            Console.ReadLine();
            Console.WriteLine(" Thanks for playing Dino World Take Over! Hope to see you soon!");
            Console.ReadLine();
            Console.WriteLine("THE END!");
            
        }
        //public void RobotsvsDinosaurs()
        //{
           
        //    //Console.Write("Please choose a fighter \n");
        //    //Console.WriteLine("Robot R2r, Robot B2b, Robot Kim, Dino pete, Dino Don, Dino Car");
        //    //string fighter = Console.ReadLine();



        //    //switch (fighter)
        //    //{
        //    //    case "Robot R2r":
        //    //        Console.WriteLine("You have picked:" + fighter + " GET READY TO FIGHT!!!");
        //    //        break;
        //    //    case "Robot B2b":
        //    //        Console.WriteLine("You have picked:" + fighter + " GET READY TO FIGHT!!!");
        //    //        break;
        //    //    case "Robot Kim":
        //    //        Console.WriteLine("You have picked:" + fighter + " GET READY TO FIGHT!!!");
        //    //        break;
        //    //    case "Dino Pete":
        //    //        Console.WriteLine("You have picked:" + fighter + " GET READY TO FIGHT!!!");
        //    //        break;
        //    //    case "Dino Don":
        //    //        Console.WriteLine("You have piced:" + fighter + " GET READY TO FIGHT!!!");
        //    //        break;
        //    //    case "Dino Car":
        //    //        Console.WriteLine("You have picked:" + fighter + " GET READY TO FIGHT!!!");
        //    //        break;
        //    //    default:
        //    //        Console.WriteLine("Not a valid fighter");
        //    //        break;

                
        //    //}
        //    //Console.WriteLine("Hit enter to begin the battle");
        //    //begin = Console.ReadLine();
        //    //Console.WriteLine("Welcome to the Battlefield!! Ready your fighter " + fighter);
        //    //Console.ReadLine();

        //}


        


        
 }  }
