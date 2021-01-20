using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class Quarter:Coin
    {
        //Member Variables (Has A)
        //protected double value; //from Coin
        //public string Name; // Coin

        //Constructor (Spawner)
        public Quarter()
        {
            value = 0.25;
            name = Quarter;
        }

        //Member Methods (Can Do)
    }
}
