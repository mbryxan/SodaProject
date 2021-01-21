using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class Nickel:Coin
    {
        //Member Variables (Has A)
        //protected double value; //from Coin parent class
        //public string Name; // from Coin parent class

        //Constructor (Spawner)
        public Nickel()
        {
            value = .05;
            Name = "Nickel";
        }
        //Member Methods (Can Do)
    }
}
