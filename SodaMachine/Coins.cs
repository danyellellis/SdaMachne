using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
     class Coins
    {
        //Member Variables (HAS A)
        public List<Quarter> Quarters;
        public List<Nickel> Nickels;
        public List<Dime> Dimes;
        public List<Penny> Pennies;
        //Constructor
        public Coins()
        {
            Quarters = new List<Quarter>();
            Nickels = new List<Nickel>();
            Dimes = new List<Dime>();
            Pennies = new List<Penny>();
            amountOfCoins();

        }
        //Member Methods (CAN DO)

        public void amountOfCoins()
        {
            for (int i = 0; i < 20; i++)
            {
                Quarter quarter = new Quarter();
                Quarters.Add(quarter);
            }
            for (int i = 0; i < 20; i++)
            {
                Nickel nickel = new Nickel();
                Nickels.Add(nickel);

            }
            for (int i = 0; i < 10; i++)
            {
                Dime dime = new Dime();
                Dimes.Add(dime);
            }
            for (int i = 0; i < 50; i++)
            {
                Penny penny = new Penny();
                Pennies.Add(penny);
            }
        }
    }
}
