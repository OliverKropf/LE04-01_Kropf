using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LE04_01_Kropf.ProductClasses
{
    public class SpicySnacks : Snacks
    {
        public SpicySnacks(string name, string description, double price, int amount) : base(name, description, price, amount)
        {
        }
    }
}
