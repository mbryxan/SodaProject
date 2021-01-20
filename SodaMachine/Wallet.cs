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
        public List<Coin> coins;

        //Constructor (Spawner)
        public Wallet()
        {
            coins = new List<Coin>();
            //Coin penny = new Coin(); //added
            //Coin nickel = new Coin(); //aded
            //Coin dime = new Dime(); //added
            //Coin quarter = new Quarter(); //added

            FillWallet();
        }
        //Member Methods (Can Do)
        //Fills wallet with starting money
        private void FillWallet()
        {
            for (int i = 0; i < 4; i++)
            {
                Penny penny = new Penny();
                coins.Add(penny);
            }

            for (int i = 0; i < 2; i++)
            {
                Nickel nickel = new Nickel();
                coins.Add(nickel);
            }

            for (int i = 0; i < 3; i++)
            {
                Dime dime = new Dime();
                coins.Add(dime);
            }

            for (int i = 0; i < 3; i++)
            {
                Quarter quarter = new Quarter();
                coins.Add(quarter);

            }
        }
       
    } 
}

 