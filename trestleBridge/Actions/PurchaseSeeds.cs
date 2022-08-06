using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trestleBridge.Actions
{
    internal class PurchaseSeeds
    {
        public static void CollectInput(Farm farm)
        {
            Console.WriteLine("1. Sesame");
            Console.WriteLine("2. Sunflower");
            Console.WriteLine("2. Wildflower");

            Console.WriteLine();
            Console.WriteLine("What are you buying today?");

            Console.Write("> ");
            string choice = Console.ReadLine();

            switch (Int32.Parse(choice))
            {
                case 1:
                    ChooseSowingField.CollectInput(farm, new Sesame());
                    break;
                case 2:
                    ChooseSowingField.CollectInput(farm, new SunFlower());
                    break;
                case 3:
                    ChooseSowingField.CollectInput(farm, new WildFlower());
                    break;
                default:
                    break;
            }
        }
    }
}
