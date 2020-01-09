using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs_Dinosaurs
{
    class Fleet
    {
        //Member variables (Has A)
       
        Robot R2r = new Robot("R2r");
        Robot B2b = new Robot("B2b");
        Robot Kim = new Robot("Kim");
        List<Robot> robos = new List<Robot>();

        //Constructor
        public Fleet()
        {
            robos.Add(R2r);
            robos.Add(B2b);
            robos.Add(Kim);
        }

        //member methods (Can Do)

    }
}
