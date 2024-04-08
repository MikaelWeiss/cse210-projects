using System.Runtime.Versioning;

class Program
{
    static List<Vision> visions;
    static void Main(string[] args)
    {
        visions = new List<Vision>();
        Console.Clear();
        DisplayMenu();
    }

    static void DisplayMenu()
    {
        Console.WriteLine("1. Today's Events");
        Console.WriteLine("2. View Visions");
        Console.WriteLine("3. Save All");
        Console.WriteLine("4. Load All");
        Console.WriteLine("5. Exit");
        Console.Write("What would you like to do? ");

        string choice = Console.ReadKey().KeyChar.ToString();

        switch (choice)
        {
            case "1":
                DisplayManager.DisplayTodaysEvents(visions);
                break;
            case "2":
                DisplayManager.DisplayVisions(visions);
                break;
            case "3":
                Vision.SaveVisions(visions);
                break;
            case "4":
                Vision.LoadVisions(visions);
                break;
            case "5":
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
}