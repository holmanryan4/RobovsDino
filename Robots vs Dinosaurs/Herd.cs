using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs_Dinosaurs
{
    class Herd
    {
        //Member variables (Has A)
        //List<string> dinos = new List<string> { "Pete", "Don", "Car" };

        //foreach(string )

        Dinosaur Don = new Dinosaur("Don");
        Dinosaur Pete = new Dinosaur("Pete");
        Dinosaur Car = new Dinosaur("Car");
        List<Dinosaur> dinos = new List<Dinosaur>();



        //Constructor
        public Herd()
        {
            dinos.Add(Don);
            dinos.Add(Pete);
            dinos.Add(Car);
        }

        //member methods (Can Do)

    }
}
