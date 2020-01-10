using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs_Dinosaurs
{
    class Robot
    {
        //Member variables (Has A)
        public string robotName;
        public int health;
        public int powerLevel;
        public int weaponAttackPower;
        //Constructor
        public Robot(string name)
        {
            this.robotName = name;
            this.health = 100;
            this.powerLevel = 50;
            this.weaponAttackPower = 50;
        }
      

        //member methods (Can Do)

        //method for attacking dino 

    }
}
