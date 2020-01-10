using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs_Dinosaurs
{
    class Dinosaur
    {
        //Member variables (Has A)
        public string dinotype;
        public int dinoHealth;
        public int energy;
        public int attackPower;


        //Constructor
        public Dinosaur(string type)
        {
            this.dinotype = type;
            this.dinoHealth = 100;
            this.energy = 50;
            this.attackPower = 50;
        }
        //member methods (Can Do)
        //method for attacking robot (robot robot)
    }
}
