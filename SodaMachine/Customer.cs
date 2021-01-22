using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class Customer
    {
        //Member Variables (Has A)
        public Wallet Wallet;
        public Backpack Backpack;

        //Constructor (Spawner)
        public Customer()
        {
            Wallet = new Wallet();

            Backpack = new Backpack();
        }
        //Member Methods (Can Do)

        //This method will be the main logic for a customer to retrieve coins form their wallet.
        //Takes in the selected can for price reference
        //Will need to get user input for coins they would like to add.
        //When all is said and done this method will return a list of coin objects that the customer will use a payment for their soda.
        public List<Coin> GatherCoinsFromWallet(Can selectedCan)
           
            
        {
            List<Coin> finalCoins = new List<Coin>();
            double price = selectedCan.Price;
            while (true)
            {
                Console.WriteLine("\n");
                Console.WriteLine("Enter -1- for Quarter");
                Console.WriteLine("Enter -2- for Dime");
                Console.WriteLine("Enter -3- for Nickel");
                Console.WriteLine("Enter -4- for Penny");
                Console.WriteLine("Enter -5- when finished to deposit payment");
                int.TryParse(Console.ReadLine(), out int selection);

                if (selection == 1)
                {
                    finalCoins.Add(GetCoinFromWallet("Quarter"));
                }

                if (selection == 5)
                    return finalCoins;
            }
        }
    //Returns a coin object from the wallet based on the name passed into it.
    //Returns null if no coin can be found
    public Coin GetCoinFromWallet(string coinName)
    {
            //get coin from wallet based on item name

            foreach (Coin coin in Wallet.coins)
            {
                if (coin.Name == coinName)
                {
                    Wallet.coins.Remove(coin);
                    return coin;
                }
            }
            return null;


        }
    //Takes in a list of coin objects to add into the customers wallet.
    public void AddCoinsIntoWallet(List<Coin> coinsToAdd)
    {
            //like soda machine on bottom
           
            foreach (Coin coin in finalCoins)
            {
               if (coinsToAdd == "Quarter")
                {
                    Wallet.coins.Add(coin);
                }

            }
    }
    //Takes in a can object to add to the customers backpack.
    public void AddCanToBackpack(Can purchasedCan)
    {

                Backpack.cans.Add(purchasedCan);
        
    }
}
}
