class Program
{
    static List<Vision> visions;
    static void Main(string[] args)
    {
        visions = new List<Vision>();
        DisplayMenu();
    }

    static void DisplayMenu()
    {
        Console.Clear();
        Console.WriteLine("1. Create Vision");
        Console.WriteLine("2. Delete Vision");
        Console.WriteLine("3. Display Visions");
        Console.WriteLine("4. Save Visions");
        Console.WriteLine("5. Load Visions");
        Console.WriteLine("6. Exit");
        Console.Write("What would you like to do? ");

        string choice = Console.ReadKey().KeyChar.ToString();

        switch (choice)
        {
            case "1":
                CreateVision();
                break;
            case "2":
                DeleteVision();
                break;
            case "3":
                DisplayVisions();
                break;
            case "4":
                SaveVisions();
                break;
            case "5":
                LoadVisions();
                break;
            case "6":
                Environment.Exit(0);
                break;
            default:
                Console.Clear();
                Console.WriteLine("Invalid choice");
                Thread.Sleep(900);
                break;
        }

        DisplayMenu();
    }

    static void CreateVision()
    {

    }

    static void DeleteVision()
    {

    }

    static void DisplayVisions()
    {

    }

    static void SaveVisions()
    {

    }

    static void LoadVisions()
    {

    }
}