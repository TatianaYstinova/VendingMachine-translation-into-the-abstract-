using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class VendingMachineCoffee : AbctractVendingMachine
    {
        public int CoffeeReminder { get; private set; }
        public int MilkReminder { get; private set; }


        public void Info()
        {
            Console.WriteLine($"Name={Name}");
            Console.WriteLine($"CoinBalance={CoinBalance}");
            Console.WriteLine($"MilkReminder={MilkReminder}");
            Console.WriteLine($"CoffeeReminder={CoffeeReminder}");
            Console.WriteLine($"Income={Income}");
            Console.WriteLine();
        }
        public void Menue()
        {
            Console.WriteLine($"Меню автомата {Name}:");
            for (int i = 0; i < Drinks.Length; i++)
            {
                Drinks crn = Drinks[i];
                Console.WriteLine($"{i + 1} - {crn.Name} {crn.Cost} руб.")
            }
        }

    }
}
