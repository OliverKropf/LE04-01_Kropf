using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LE04_01_Kropf.VendingMachineData
{
    internal class ChooseMenue
    {
        public static void ChooseProduct()
        {
            Console.WriteLine("Welcome to the Vending Machine!\n");
            VendingMachineMethods.GenerateProducts();
            int userDecision;

            do
            {
                Console.WriteLine("---------------------------------------------------------\n" +
                                  "     1 = Coca Cola                     [ 0.5l]  [1.50EUR]\n" +
                                  "     2 = Coca Cola                     [   1l]  [2.60EUR]\n" +
                                  "     3 = Mineral Water(non-sparkling)  [ 0.5l]  [0.80EUR]\n" +
                                  "     4 = Mineral Water(non-sparkling)  [   1l]  [1.30EUR]\n" +
                                  "     5 = Mineral Water(sparkling)      [ 0.5l]  [0.80EUR]\n" +
                                  "     6 = Mineral Water(sparkling)      [   1l]  [1.30EUR]\n" +
                                  "     7 = Ice Coffee                    [ 0.5l]  [1.20EUR]\n" +
                                  "     8 = Ice Coffee                    [   1l]  [1.90EUR]\n" +
                                  "     9 = Red Bull                      [ 0.5l]  [2.50EUR]\n" +
                                  "     10 = Red Bull                     [   1l]  [4.20EUR]\n" +
                                  "     11 = Haribo                       [  75g]  [1.40EUR]\n" +
                                  "     12 = Skittles                     [ 175g]  [1.50EUR]\n" +
                                  "     13 = Smarties                     [ 130g]  [1.80EUR]\n" +
                                  "     14 = Pringles (hot & spicy)       [  40g]  [1.10EUR]\n" +
                                  "     15 = Doritos                      [ 110g]  [1.90EUR]\n" +
                                  "     16 = Snips                        [ 150g]  [1.70EUR]\n" +
                                  "     0 = Exit\n" +
                                  "---------------------------------------------------------\n" +
                                  "Choose what you want: \n");

                userDecision = InputCoverage.IntRequest();
                VendingMenue.Spreading(userDecision);

            } while (userDecision != 0);
        }
    }
}
