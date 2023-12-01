using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class Drinks
    {
        public string Name { get; private set; }   
        public int NeededCoffee { get; private set; }
        public int NeededMilk { get; private set; }
        public int Cost { get; private set; }
        public Drinks(string name, int cost, int neededCoffe, int neededMilk)
        {
            Name = name;
            Cost = cost;
            NeededCoffee = neededCoffe;
            NeededMilk = neededMilk;
        }

    }
}
