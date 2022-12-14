using trestleBridge;
using trestleBridge.Actions;
using trestleBridge.Models;

static void DisplayBanner()
{
    Console.Clear();
    Console.WriteLine();
    Console.WriteLine(@"
        +-++-++-++-++-++-++-++-++-++-++-++-++-+
        |T||r||e||s||t||l||e||b||r||i||d||g||e|
        +-++-++-++-++-++-++-++-++-++-++-++-++-+
                    |F||a||r||m||s|
                    +-++-++-++-++-+");
    Console.WriteLine();
}

static void Start()
{
    Console.BackgroundColor = ConsoleColor.DarkMagenta;
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.White;
    Farm Trestlebridge = new Farm();
    bool usingFarm = true;
    while (usingFarm)
    {
        DisplayBanner();
        Console.WriteLine("1. Create Facility");
        Console.WriteLine("2. Purchase Animals");
        Console.WriteLine("3. Purchase Seeds");
        Console.WriteLine("4. Display Farm Status");
        Console.WriteLine("5. Exit");
        Console.WriteLine();
        Console.WriteLine("Choose a FARMS option");
        Console.Write("> ");
        string option = Console.ReadLine();
        if (option == "1")
        {
            DisplayBanner();
            CreateFacility.CollectInput(Trestlebridge);
        }
        else if (option == "2")
        {
            DisplayBanner();
            PurchaseStock.CollectInput(Trestlebridge);
        }
        else if (option == "3")
        {
            DisplayBanner();
            PurchaseSeeds.CollectInput(Trestlebridge);
        }
        else if (option == "4")
        {
            DisplayBanner();
            Console.WriteLine(Trestlebridge);
            Console.WriteLine("\n\n\n");
            Console.WriteLine("Press return key to go back to main menu.");
            Console.ReadLine();
        }
        else if (option == "5")
        {
            Console.WriteLine("Today was a great day for farming");
            usingFarm = false;

            break;
        }
        else
        {
            Console.WriteLine($"Invalid option: {option}");
        }
    }
}

Start();