using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class Penny:Coin
    {
        //Member Variables (Has A)
        //protected double value; //from Coin parent class
        //public string Name; // from Coin parent class

        //Constructor (Spawner)
        public Penny()
        {
            value = .01;
            Name = "Penny";
        }
        //Member Methods (Can Do)
    }
}
