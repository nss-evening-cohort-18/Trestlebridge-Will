using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trestleBridge.Interfaces;

namespace trestleBridge.Actions
{
    internal class ChoosePlowedField
    {
        public static void CollectInput(Farm farm, IFlower plant)
        {
            Console.Clear();
            for (int i = 0; i < farm.PlowedFields.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Plowed Field ({farm.PlowedFields[i].OccupiedSpace()} rows of plants)");
            }
            Console.WriteLine();
            // How can I output the type of animal chosen here?
            Console.WriteLine($"Place {plant.Type.ToString().ToLower()} where?");

            Console.Write("> ");
            int choice = Int32.Parse(Console.ReadLine());

            farm.PlowedFields[choice - 1].AddResource(plant);

            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(animal, choice);
        }
    }
}
