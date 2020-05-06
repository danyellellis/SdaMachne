using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class SodaMachine 
    {
        //Member Variables (HAS A)
        
            Coins Coins;
        Cans Cans;

        //Constructor
        public SodaMachine()
        {
            Coins = new Coins();
            Cans = new Cans();
        }
        //Member Methods (CAN DO)

        public void sodaSelectWindow()
        {
            Console.WriteLine("Soda Machine");
            bool drinkPurchase = false;
            while (drinkPurchase = false)
            {
                do
                {
                    Console.WriteLine("Choose your Drink Grape, Lemon, or Orange.");
                    string input = Console.ReadLine().ToLower();
                    switch (input)
                    {
                        case "Grape":
                        ChooseGrape();
                        break;
                        case "Orange":
                       // ChooseOrange();
                        break;
                        case "Lemon":
                       // ChooseLemon();
                        break;

                        default:
                            Console.WriteLine("Thanks!")
                            break;
                    }
                } while (true);
                Console.ReadLine();

            }
        }
        
        public void ChooseGrape()
        {
            int input;
            do
            {
                //if (input <= Cans.Grapes.Count)
               // {
               //     Give money back 
             //   }
            } while (true);
        }
    }
}
