using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trestleBridge.Interfaces;
using trestleBridge.Models.Facilities;

namespace trestleBridge.Actions
{
    internal class ChooseNaturalOrPlowed
    {
        public static void CollectInput(Farm farm, IFlower plant)
        {
            Console.Clear();
            List<IFacility<IFlower>> CombinedList = new List<IFacility<IFlower>>();
            CombinedList.AddRange(farm.NaturalFields);
            CombinedList.AddRange(farm.PlowedFields);
            string type = "";
            for (int i = 0; i < CombinedList.Count; i++)
            {
                if (CombinedList[i].GetType() == typeof(NaturalField))
                {
                    type = "Natural Field";
                } else
                {
                    type = "Plowed Field";
                };
                Console.WriteLine($"{i +1}. {type} {CombinedList[i].OccupiedSpace()} rows of plants");
            }
            Console.WriteLine();
            // How can I output the type of animal chosen here?
            Console.WriteLine($"Place {plant.Type.ToString().ToLower()} where?");

            Console.Write("> ");
            int choice = Int32.Parse(Console.ReadLine());
            CombinedList[choice - 1].AddResource(plant);
            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(animal, choice);
        }
    }
}
