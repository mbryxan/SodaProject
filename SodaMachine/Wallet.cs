using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class Wallet
    {
        //Member Variables (Has A)
        public List<Coin> Coins;

        //Constructor (Spawner)
        public Wallet()
        {
            Coins = new List<Coin>();
            Coin penny = new Coin(); //added
            Coin nickel = new Coin(); //aded
            Coin dime = new Dime(); //added
            Coin quarter = new Quarter(); //added

            FillRegister();
        }
        //Member Methods (Can Do)
        //Fills wallet with starting money
        private void FillRegister()
        {
            for (int startingPennyCount = 0; startingPennyCount < 50; startingPennyCount++)
            {
                if
                   (startingPennyCount < 50)
                    startingPennyCount++;
            }
            
            for (int startingNickelCount = 0; startingNickelCount < 20; startingNickelCount++)
            {
                if
                    (startingNickelCount < 20)
                    startingNickelCount++;
            }
            
            for (int startingDimeCount = 0; startingDimeCount < 10; startingDimeCount++)
            {
                if
                    (startingDimeCount < 10)
                    startingDimeCount++;
            }
           
            for (int startingQuarterCount = 0; startingQuarterCount < 20; startingQuarterCount++)
            {
                if
                    (startingQuarterCount < 20)
                    startingQuarterCount++;
            }






        }
    }
}

 