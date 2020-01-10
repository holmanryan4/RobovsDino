using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs_Dinosaurs
{
    class Weapon
    {
        //Member variables (Has A)
        public string weapontype;
        public int weaponAttackPower;
        //Constructor
        public Weapon(string type)
        {
            this.weapontype = type;
           // this.weaponAttackPower = 50;

        }

        //not working
        // Weapon= new Weapon("sword");
        List<Weapon> weapons = new List<Weapon>();

        //member methods (Can Do)

    }
}
