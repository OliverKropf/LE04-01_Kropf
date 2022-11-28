using System;

namespace LE04_01_Kropf.ProductClasses
{
    public abstract class Snacks
    {
        public Snacks(string name, string description, double price, int amount)
        {
            Name = name;
            Description = description;
            Price = price;
            Amount = amount;
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual double Price { get; protected set; }
        public int Amount { get; set; }

        public virtual void Display(Snacks chosenProduct, int productNumber)
        {
            if (chosenProduct is Drink)
            {
                Console.Clear();
                Console.WriteLine($"\nYou chose Nr. {productNumber}" +
                                  $"\nName:         {chosenProduct.Name}" +
                                  $"\nDescription:  {chosenProduct.Description} " +
                                  $"\nCapacity:     {VendingMachineMethods.ReturnCapacity((Drink)chosenProduct)}l" +
                                  $"\nPrice:        {chosenProduct.Price} EUR" +
                                  $"\nAmount:       {chosenProduct.Amount}");
            }
            else
            {
                Console.Clear();
                Console.WriteLine($"\nYou chose Nr. {productNumber}" +
                                  $"\nName:         {chosenProduct.Name}" +
                                  $"\nDescription:  {chosenProduct.Description}" +
                                  $"\nPrice:        {chosenProduct.Price} EUR" +
                                  $"\nAmount:       {chosenProduct.Amount}");
            }
        }
    }
}
