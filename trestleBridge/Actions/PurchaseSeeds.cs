using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trestleBridge.Models.Plants;

namespace trestleBridge.Actions
{
    internal class PurchaseSeeds
    {
        public static void CollectInput(Farm farm)
        {
            Console.WriteLine("1. Sesame");
            Console.WriteLine("2. Sunflower");
            Console.WriteLine("3. Wildflower");

            Console.WriteLine();
            Console.WriteLine("What are you buying today?");

            Console.Write("> ");
            string choice = Console.ReadLine();

            switch (Int32.Parse(choice))
            {
                case 1:
                    if (farm.PlowedFields.Count == 0)
                    {
                        Console.WriteLine(@"Sorry, but no fields exist to plant Sesame.
Please create the appropriate facility first, then purchase Sesame.
Press any key to return to the main menu");
                        Console.ReadKey();
                    }
                    else
                    {
                        ChoosePlowedField.CollectInput(farm, new Sesame());
                    }
                    break;
                case 2:
                    if (farm.PlowedFields.Count == 0 && farm.NaturalFields.Count == 0)
                    {
                        Console.WriteLine(@"Sorry, but no fields exist to plant Sunflower.
Please create the appropriate facility first, then purchase Sunflower.
Press any key to return to the main menu");
                        Console.ReadKey();
                    }
                    else
                    {
                        ChooseNaturalOrPlowed.CollectInput(farm, new Sunflower());
                    }
                    break;
                case 3:
                    if (farm.NaturalFields.Count == 0)
                    {
                        Console.WriteLine(@"Sorry, but no fields exist to plant WildFlower.
Please create the appropriate facility first, then purchase Wildflower.
Press any key to return to the main menu");
                        Console.ReadKey();
                    }
                    else
                    {
                        ChooseNaturalField.CollectInput(farm, new Wildflower());
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
