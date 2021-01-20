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
        private int startingPennyCount;//added
        private int startingNickelCount; //added
        private int startingDimeCount; //added
        private int startingQuarterCount; //added
        private int startingColaCount; //added
        private int startingOrangeSodaCount; //added
        private int startingRootBeerCount; //added

        //Constructor (Spawner)
        public SodaMachine()
        {
            _register = new List<Coin>(); //added
            Coin penny = new Coin();
            Coin nickel = new Coin();
            Coin dime = new Coin();
            Coin quarter = new Coin();

            _register.Add(penny);
            _register.Add(nickel);
            _register.Add(dime);
            _register.Add(quarter);

            _inventory = new List<Can>();
            Can cola = new Can(); //added
            Can orangeSoda = new Can();
            Can rootBeer = new Can();

            _inventory.Add(cola);
            _inventory.Add(orangeSoda);
            _inventory.Add(rootBeer);

            //starting inventory for coins in machine
            startingPennyCount = 0;
            startingNickelCount = 0;
            startingDimeCount = 0;
            startingQuarterCount = 0;
            //starting inventory for cans in machine
            startingColaCount = 0;
            startingOrangeSodaCount = 0;
            startingRootBeerCount = 0;

            //added
        }

        //Member Methods (Can Do)

        //A method to fill the sodamachines register with coin objects.

        public void FillRegister() //loop
        {
            //determine starting amount for each coins


            //add 50 pennies (50 x .01)
            for (int startingPennyCount = 0; startingPennyCount < 50; startingPennyCount++)
            {
                if
                   (startingPennyCount < 50)
                    startingPennyCount++;
            }
            //add 20 nickels (20 x .05)
            for (int startingNickelCount = 0; startingNickelCount < 20; startingNickelCount++)
            {
                if
                    (startingNickelCount < 20)
                    startingNickelCount++;
            }
            //add 10 dimes (10 x.10)
            for (int startingDimeCount = 0; startingDimeCount < 10; startingDimeCount++)
            {
                if
                    (startingDimeCount < 10)
                    startingDimeCount++;
            }
            //add 20 quarters (20 x .25)
            for (int startingQuarterCount = 0; startingQuarterCount < 20; startingQuarterCount++)
            {
                if
                    (startingQuarterCount < 20)
                    startingQuarterCount++;
            }

        }

        //A method to fill the sodamachines inventory with soda can objects.
        public void FillInventory() //loop

        //add 10 sodas
        {
            for (int startingColaCount = 0; startingColaCount < 10; startingColaCount++)
            {
                if (startingColaCount < 20)
                    startingColaCount++;
            }
            //add 15 orangeSoda
            for (int startingOrangeSodaCount = 0; startingOrangeSodaCount < 15; startingOrangeSodaCount++)
            {
                if (startingOrangeSodaCount < 20)
                    startingOrangeSodaCount++;
            }
            //add 10 rootBeer
            for (int startingRootBeerCount = 10; startingRootBeerCount < 10; startingRootBeerCount++)
            {
                if (startingRootBeerCount < 10)
                    startingRootBeerCount++;
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
        private Can GetSodaFromInventory(string nameOfSoda)
        {

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

        }
        //Takes in the value of the amount of change needed.
        //Attempts to gather all the required coins from the sodamachine's register to make change.
        //Returns the list of coins as change to despense.
        //If the change cannot be made, return null.
        private List<Coin> GatherChange(double changeValue)
        {

        }
        //Reusable method to check if the register has a coin of that name.
        //If it does have one, return true.  Else, false.
        private bool RegisterHasCoin(string name)
        {

        }
        //Reusable method to return a coin from the register.
        //Returns null if no coin can be found of that name.
        private Coin GetCoinFromRegister(string name)
        {

        }
        //Takes in the total payment amount and the price of can to return the change amount.
        private double DetermineChange(double totalPayment, double canPrice)
        {

        }
        //Takes in a list of coins to returnt he total value of the coins as a double.
        private double TotalCoinValue(List<Coin> payment)
        {

        }
        //Puts a list of coins into the soda machines register.
        private void DepositCoinsIntoRegister(List<Coin> coins)
        {

        }
    }
}
