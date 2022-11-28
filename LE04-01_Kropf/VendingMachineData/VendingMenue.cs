using LE04_01_Kropf.ProductClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LE04_01_Kropf.VendingMachineData
{
    internal class VendingMenue
    {
        public static void Spreading(int decision)
        {
            switch (decision) // first case for drinks = 0.5l, second case = 1l
            {
                case 1: case 2: 
                    Drink Cola = (Drink)VendingMachineMethods.ReturnProduct(decision - 1);
                    Execution(Cola, decision);
                    break;
                case 3: case 4: 
                    Drink Mineral = (Drink)VendingMachineMethods.ReturnProduct(decision - 1);
                    Execution(Mineral, decision);
                    break;
                case 5: case 6: 
                    Drink SparklingWater = (Drink)VendingMachineMethods.ReturnProduct(decision - 1);
                    Execution(SparklingWater, decision);
                    break;
                case 7: case 8: 
                    Drink IceCoffee = (Drink)VendingMachineMethods.ReturnProduct(decision - 1);
                    Execution(IceCoffee, decision);
                    break;
                case 9: case 10: 
                    Drink RedBull = (Drink)VendingMachineMethods.ReturnProduct(decision - 1);
                    Execution(RedBull, decision);
                    break;
                case 11: 
                    SweetSnacks Haribo = (SweetSnacks)VendingMachineMethods.ReturnProduct(decision - 1);
                    Execution(Haribo, decision);
                    break;
                case 12:
                    SweetSnacks Skittles = (SweetSnacks)VendingMachineMethods.ReturnProduct(decision - 1);
                    Execution(Skittles, decision);
                    break;
                case 13:
                    SweetSnacks Smarties = (SweetSnacks)VendingMachineMethods.ReturnProduct(decision - 1);
                    Execution(Smarties, decision);
                    break;
                case 14:
                    SpicySnacks Pringles = (SpicySnacks)VendingMachineMethods.ReturnProduct(decision - 1);
                    Execution(Pringles, decision);
                    break;
                case 15:
                    SpicySnacks Doritos = (SpicySnacks)VendingMachineMethods.ReturnProduct(decision - 1);
                    Execution(Doritos, decision);
                    break;
                case 16:
                    SpicySnacks Snips = (SpicySnacks)VendingMachineMethods.ReturnProduct(decision - 1);
                    Execution(Snips, decision);
                    break;
            }
        }
        public static void Execution(Snacks product, int decision)
        {
            if (!VendingMachineMethods.CheckAmountOfProduct(product))
            {
                Console.WriteLine("\nSorry but the vending machine is out of your desired product!\n");
                return;
            }
            VendingMachineMethods.BaskedCheckAndDescriptionPrint(product, decision);
            VendingMachineMethods.AddProductToBasket(product);
            VendingMachineMethods.ReduceProductAmount(product);
            if (VendingMachineMethods.DoesUserWantToAddMore(product)) return;
            else 
            {
                MoneyMethods.Expense();
            }
        }
    }
}
