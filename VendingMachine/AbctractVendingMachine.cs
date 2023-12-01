using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public abstract class AbctractVendingMachine
    {
        public string Name { get;  set; }
 
        public int CoinBalance { get;  private set; }
        public int  Income {get; private set; }
        public Drinks[] Drinks { get; private set; }
        public AbctractVendingMachine(string name, Drinks[]drinks)
        {
            Name = name;
            Drinks = drinks;
            CoinBalance = 0;
            Income = 0;
        }
        public string DoInfotmation()
        {
            return $"Name :{Name}, CoinBalance :{CoinBalance} ,Income :{Income} ";
        }

    }
}
