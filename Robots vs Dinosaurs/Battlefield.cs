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
        public void RobotsvsDinosaurs()
        {
            Console.Write("Please choose a fighter");
            string fighter = Console.ReadLine();
            

            switch (fighter)
            {
                case "Robot R2r":
                    Console.WriteLine("You have picked R2r" + fighter);
                    break;
                case "Robot B2b":
                    Console.WriteLine("You have piced B2b" + fighter);
                    break;
                case "Robot Kim":
                    Console.WriteLine("You have picked Kim" + fighter);
                    break;
                case "Dino Pete":
                    Console.WriteLine("You have picked Pete" + fighter);
                    break;
                case "Dino Don":
                    Console.WriteLine("You have piced Don" + fighter);
                    break;
                case "Dino Car":
                    Console.WriteLine("You have picked Car" + fighter);
                    break;
                default:
                    Console.WriteLine("Not a valid fighter");
                    break;

            }
        }
        }

        //Constructor

        //member methods (Can Do)

    
}
