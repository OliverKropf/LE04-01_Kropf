﻿using LE04_01_Kropf.ProductClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LE04_01_Kropf
{
    internal class MoneyMethods 
    {
        public static void Expense()
        {
            double totalPrice = 0;
            Dictionary<double, string> PriceAndName = VendingMachineMethods.ReturnPriceAndNameDictionary();
            Console.Clear();
            foreach(KeyValuePair<double, string> kvp in PriceAndName)
            {
                Console.WriteLine($"Product:   {kvp.Value}\n" +
                                  $"$Price:                                  [{kvp.Key}EUR]");
                totalPrice += kvp.Key;
            }
            Console.WriteLine("---------------------------------------------------------\n");
            Console.WriteLine($"Total amount:                             [{totalPrice}EUR]");

            double payment = 0;
            do
            {
                Console.WriteLine($"Enter your payment:\nYou need to pay {totalPrice - payment:0.00} EUR.");
                payment += Math.Round(InputCoverage.MoneyRequest(), 2);
                
            } while (Math.Round(payment, 2) < totalPrice);

            if (payment - totalPrice > 0) Console.WriteLine($"You get {payment - totalPrice:0.00} EUR back."); 
            Console.WriteLine("\nThank you for buying from this vending machine!");
            
            VendingMachineMethods.ClearLists(); 
        }
    }
}