using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class Cans
    {
        //Member Variables (HAS A)
        public List<Grape> Grapes;
        public List<Orange> Oranges;
        public List<Lemon> Lemons;
        public double amount;
        //Constructor
        public Cans()
        {
            Grapes = new List<Grape>();
            Oranges = new List<Orange>();
            Lemons = new List<Lemon>();
            amountOfDrinksToBuy();
        }
        //Member Methods (CAN DO)
        public void amountOfDrinksToBuy()
        {
            for (int i = 0; i < 10; i++)
            {
                Grape grape = new Grape();
                Grapes.Add(grape);
            }
            for (int i = 0; i < 15; i++)
            {
                Lemon lemon = new Lemon();
                Lemons.Add(lemon);
            }
            for (int i = 0; i < 5; i++)
            {
                Orange orange = new Orange();
                Oranges.Add(orange);
            }
        }

    }
}
