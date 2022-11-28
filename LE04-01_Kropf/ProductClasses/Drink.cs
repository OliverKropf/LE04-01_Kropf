using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace LE04_01_Kropf.ProductClasses
{
    public class Drink : Snacks
    {
        public Drink(string name, string description, double price, int amount, double capacity) : base(name, description, price, amount)
        {
            Capacity = capacity;
        }
        public double Capacity { get; set; }
    }
}
