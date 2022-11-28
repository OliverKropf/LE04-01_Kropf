using System;
using System.Windows;

namespace LE04_01_Kropf
{
    internal class InputCoverage
    {
        public static int IntRequest() 
        {
            while (true)
            {
                try
                {
                    return int.Parse(Console.ReadLine());
                }
                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message, "Fehlermeldung");
                    Console.WriteLine("try again:\n");
                }
            }
        }
        public static double MoneyRequest()
        {
            double payment;
            do
            {
               
                Console.WriteLine("\nYou can enter coins aswell as notes, everything below 5 cents won't be accepted.\n");
                string s = Console.ReadLine().Replace(".", ",");
                payment = double.Parse(s);
                //Console.WriteLine(payment);
                //Console.WriteLine(Math.Round(payment * 100) % 5); 
            }
            while (Math.Round(payment * 100) % 5 != 0);

            return payment;
        }
    }
}

