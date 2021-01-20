using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class RootBeer:Can
    {
        //Member Variables (Has A)
        //protected double price; from Can parent class
        //public string Name; from Can parent class

        //Constructor (Spawner)
        public RootBeer()
        {
            Name = "Root Beer";
            price = 0.30;
        }
        //Member Methods (Can Do)
    }
}
