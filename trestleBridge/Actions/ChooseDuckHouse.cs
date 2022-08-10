using System;
using trestleBridge.Interfaces;

namespace trestleBridge.Actions
{
	public class ChooseDuckHouse
	{
		
            public static void CollectInput(Farm farm, IGrazing animal)
            {
                Console.Clear();
                for (int i = 0; i < farm.DuckHouses.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. Duck House");
                }
                Console.WriteLine();
                // How can I output the type of animal chosen here?
                Console.WriteLine($"Place {animal.Type.ToString().ToLower()} where?");

                Console.Write("> ");
                int choice = Int32.Parse(Console.ReadLine());

                farm.DuckHouses[choice].AddResource(animal);

                /*
                    Couldn't get this to work. Can you?
                    Stretch goal. Only if the app is fully functional.
                 */
                // farm.PurchaseResource<IGrazing>(animal, choice);
            }
        
	}
}

