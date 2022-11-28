using LE04_01_Kropf.ProductClasses;
using System;
using System.Collections.Generic;

namespace LE04_01_Kropf
{
    public class VendingMachineMethods
    {
        static Dictionary<int, Snacks> VendingMachineContent = new Dictionary<int, Snacks>(); 
        public static List<Snacks> Basket = new List<Snacks>();
        public static void GenerateProducts()
        {
            Drink Cola = new Drink("Coca Cola", "53g sugar per 0,5l/Coloring E 150d", 1.50, 5, 0.5);
            Drink CocaCola = new Drink("Coca Cola", "53g sugar per 0,5l/Coloring E 150d", 2.60, 5, 1);
            Drink Mineral = new Drink("Mineral Water (non-sparkling)", "Sulfate/Magnesium", 0.80, 5, 0.5);
            Drink BigMineral = new Drink("Mineral Water (non-sparkling)", "Sulfate/Magnesium", 1.30, 5, 1);
            Drink SparklingWater = new Drink("Mineral Water (sparkling)", "Sulfate/Magnesium", 0.80, 5, 0.5);
            Drink BigSparklingWater = new Drink("Mineral Water (sparkling)", "Sulfate/Magnesium", 1.30, 5, 1);
            Drink IceCoffee = new Drink("Ice Coffee", "Glucose syrup/Coloring(Carotine)", 1.20, 5, 0.5);
            Drink BigIceCoffee = new Drink("Ice Coffee", "Glucose syrup/Coloring(Carotine)", 1.90, 5, 1);
            Drink RedBull = new Drink("Red Bull", "lots of Sugar/Taurine/Caffeine", 2.40, 5, 0.5);
            Drink BigRedBull = new Drink("Red Bull", "lots of Sugar/Taurine/Caffeine", 4.20, 5, 1);

            SweetSnacks Haribo = new SweetSnacks("Haribo", "lots of Sugar/Carbonhydrate", 1.40, 5);
            SweetSnacks Skittles = new SweetSnacks("Skittles", "lots of Sugar/Carbonhydrate", 1.50, 5);
            SweetSnacks Smarties = new SweetSnacks("Smarties", "lots of Sugar/Carbonhydrate", 1.80, 5);

            SpicySnacks Pringles = new SpicySnacks("Pringles (hot & spicy)", "high calorific value/small can", 1.10, 5);
            SpicySnacks Doritos = new SpicySnacks("Doritos (sweet chilli pepper)", "high calorific value/lots of fat", 1.90, 5);
            SpicySnacks Snips = new SpicySnacks("Kelly Snips", "Protein/lots of Nuts", 1.70, 5);

            FillMachineWithProducts(Cola, CocaCola, Mineral, BigMineral, SparklingWater, BigSparklingWater, IceCoffee,
                                    BigIceCoffee, RedBull, BigRedBull, Haribo, Skittles, Smarties, Pringles, Doritos, Snips);
        }
        private static void FillMachineWithProducts (params Snacks[] products) 
        {
            for(int i = 0; i < products.Length; i++)
            {
                VendingMachineContent.Add(i, products[i]);
            }
        }
        public static Snacks ReturnProduct(int key)
        {
            return VendingMachineContent[key];  
        }
        public static void AddProductToBasket(Snacks product)
        {
            if (Basket.Count != 3)
            {
                Basket.Add(product);
                Console.WriteLine("Product was successfully added to you 'shopping basket'!\n\n");
            }
            else Console.WriteLine("\nYou can only buy 3 items at once!\n");
        }
        public static void BaskedCheckAndDescriptionPrint(Snacks product, int decision) 
        {
            if (Basket.Count == 3) Console.Clear();
            else product.Display(product, decision);
        }

        /// <summary>
        /// This Method asks the user if he wants to add another product to his basket, reduces the amount of the specific product!
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public static bool DoesUserWantToAddMore(Snacks product) 
        {
            int awnser;
            do 
            {
                Console.WriteLine("Do you want to add another Product?\n1 = yes\n2 = you will be send to payment");
                awnser = InputCoverage.IntRequest();

            }while(awnser != 1 && awnser!= 2);

            product.Amount--;

            if (awnser == 1)
            {
                Console.Clear();
                return true;
            }
            return false;
        }
        public static List<Snacks> ReturnBasket()
        {
            return Basket;
        }
        public static bool CheckAmountOfProduct(Snacks product)
        {
            if(product.Amount == 0) return false;
            return true;
        }
        public static double ReturnCapacity(Drink d)
        {
            return Convert.ToDouble(d.Capacity);
        }
        public static void ClearBasket()
        {
            Basket.Clear(); 
        }
    }
}
