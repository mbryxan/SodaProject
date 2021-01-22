using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class SodaMachine
    {
        //Member Variables (Has A)
        private List<Coin> _register;
        private List<Can> _inventory;


        //Constructor (Spawner)
        public SodaMachine()
        {
            _register = new List<Coin>();
            _inventory = new List<Can>();
        }

        //Member Methods (Can Do)

        //A method to fill the sodamachines register with coin objects.

        public void FillRegister() //loop
        {


            for (int i = 0; i < 50; i++)
            {
                Penny penny = new Penny();
                _register.Add(penny);
            }

            for (int i = 0; i < 20; i++)
            {
                Nickel nickel = new Nickel();
                _register.Add(nickel);
            }

            for (int i = 0; i < 10; i++)
            {
                Dime dime = new Dime();
                _register.Add(dime);
            }

            for (int i = 0; i < 20; i++)
            {
                Quarter quarter = new Quarter();
                _register.Add(quarter);
            }
        }

        //A method to fill the sodamachines inventory with soda can objects.
        public void FillInventory() //loop

        //add 10 cola
        {
            for (int i = 0; i < 20; i++)
            {
                Cola cola = new Cola();
                _inventory.Add(cola);
            }
            //add 15 OrangeSoda
            for (int i = 0; i < 5; i++)
            {
                OrangeSoda orangeSoda = new OrangeSoda();
                _inventory.Add(orangeSoda);
            }
            //add 10 RootBeer
            for (int i = 0; i < 5; i++)
            {
                RootBeer rootbeer = new RootBeer();
                _inventory.Add(rootbeer);
            }
        }

        //Method to be called to start a transaction.
        //Takes in a customer which can be passed freely to which ever method needs it.
        public void BeginTransaction(Customer customer)
        {
            bool willProceed = UserInterface.DisplayWelcomeInstructions(_inventory);
            if (willProceed)
            {
                Transaction(customer);
            }
        }

        //This is the main transaction logic think of it like "runGame".  This is where the user will be prompted for the desired soda.
        //grab the desired soda from the inventory.
        //get payment from the user.
        //pass payment to the calculate transaction method to finish up the transaction based on the results.
        private void Transaction(Customer customer)
        {

        }
        //Gets a soda from the inventory based on the name of the soda.
        private Can GetSodaFromInventory(string nameOfSoda) //check this

        {
            foreach (Can can in _inventory)
            {
                if (can.Name == nameOfSoda)
                {
                    _inventory.Remove(can);
                    return can;
                }
            }
            return null;
        }
        //This is the main method for calculating the result of the transaction.
        //It takes in the payment from the customer, the soda object they selected, and the customer who is purchasing the soda.
        //This is the method that will determine the following:
        //If the payment is greater than the price of the soda, and if the sodamachine has enough change to return: Dispense soda, and change to the customer.
        //If the payment is greater than the cost of the soda, but the machine does not have ample change: Dispense payment back to the customer.
        //If the payment is exact to the cost of the soda:  Dispense soda.
        //If the payment does not meet the cost of the soda: dispense payment back to the customer.
        private void CalculateTransaction(List<Coin> payment, Can chosenSoda, Customer customer)
        {
            if (TotalCoinValue(payment) > chosenSoda.Price)
            {

            }

        }
        //Takes in the value of the amount of change needed.
        //Attempts to gather all the required coins from the sodamachine's register to make change.
        //Returns the list of coins as change to despense.
        //If the change cannot be made, return null.
        private List<Coin> GatherChange(double change)

        {
            List<Coin> finalCoins = new List<Coin>();
            if (change >= 0.25 && RegisterHasCoin("Quarter"))
            {
                finalCoins.Add(GetCoinFromRegister("Quarter"));
                change = change - .25;
            }

            else if (change >= .10 && RegisterHasCoin("Dime"))
            {
                finalCoins.Add(GetCoinFromRegister("Dime"));
                change = change - .10;
            }

            else if (change >= .05 && RegisterHasCoin("Nickel"))
            {
                finalCoins.Add(GetCoinFromRegister("Nickel"));
                change = change - .05;
            }

            else if (change >= .01 && RegisterHasCoin("Penny"))
            {
                finalCoins.Add(GetCoinFromRegister("Penny"));
                change = change - .01;
            }

            return finalCoins;
        }
        //Reusable method to check if the register has a coin of that name.
        //If it does have one, return true.  Else, false.
        private bool RegisterHasCoin(string name)
        {
            foreach (Coin coin in _register)
            {
                if (coin.Name == name)
                    return true;
            }
            return false;

        }
        //Reusable method to return a coin from the register.
        //Returns null if no coin can be found of that name.
        private Coin GetCoinFromRegister(string name)
        {
            foreach (Coin coin in _register)
            {
                if (coin.Name == name)
                {
                    _register.Remove(coin);
                    return coin;
                }
            }
            return null;
        }
        //Takes in the total payment amount and the price of can to return the change amount.
        private double DetermineChange(double totalPayment, double canPrice)
        {
            return totalPayment - canPrice;
        }
        //Takes in a list of coins to return the total value of the coins as a double.
        private double TotalCoinValue(List<Coin> payment)
        {
            double total = 0;
            foreach (Coin coin in payment)
            {
                total = total + coin.Value;
            }
            return total;
        }

        //Puts a list of coins into the soda machines register.
        private void DepositCoinsIntoRegister(List<Coin> coins)
        {

            Penny penny = new Penny();
            _register.Add(penny);



            Nickel nickel = new Nickel();
            _register.Add(nickel);



            Dime dime = new Dime();
            _register.Add(dime);



            Quarter quarter = new Quarter();
            _register.Add(quarter);
        }

    }

}


