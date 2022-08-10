using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trestleBridge.Interfaces;

namespace trestleBridge.Actions
{
    internal class ChooseNaturalOrPlowed
    {
        public static void CollectInput(Farm farm, IFlower plant)
        {
            Console.Clear();
            for (int i = 0; i < farm.NaturalFields.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Natural Field");
            }
            for (int i = farm.NaturalFields.Count; i < farm.PlowedFields.Count + farm.NaturalFields.Count + 1; i++)
            {
                Console.WriteLine($"{i + 1}. Plowed Field");
            }
            Console.WriteLine();
            // How can I output the type of animal chosen here?
            Console.WriteLine($"Place {plant.Type.ToString().ToLower()} where?");

            Console.Write("> ");
            int choice = Int32.Parse(Console.ReadLine());

            if (choice <= farm.NaturalFields.Count)
            {
                farm.NaturalFields[choice - 1].AddResource(plant);
            }
            else if (choice > farm.NaturalFields.Count)
            {
                farm.PlowedFields[choice - farm.NaturalFields.Count - 1].AddResource(plant);
            }

            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(animal, choice);
        }
    }
}
