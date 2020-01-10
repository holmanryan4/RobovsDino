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
        public Weapon tools;
        public List<Weapon> toolOptions;

        // TODO: replace
        public int weaponAttackPower;

        //Constructor

        public Robot(string name)
        {
            this.robotName = name;
            this.health = 100;
            this.powerLevel = 50;
            this.weaponAttackPower = 50;

            toolOptions = new List<Weapon>();

            Weapon sword = new Weapon("sword", 50);
            Weapon axe = new Weapon("axe", 50);
            Weapon stick = new Weapon("stick", 10);

            // add those objects to the list


            
        }
      

        //member methods (Can Do)

        public void SelectWeapon()
        {
            SelectWeapon.Add 
            // set 'tools' object by calling selectweapon
            tools = toolOptions[];
        }

        //method for attacking dino 

    }
}
