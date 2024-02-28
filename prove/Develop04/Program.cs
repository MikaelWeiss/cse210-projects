using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayMenu();
    }

    static void DisplayMenu()
    {
        Console.WriteLine("1. Breathing");
        Console.WriteLine("2. Reflection");
        Console.WriteLine("3. Listing");
        Console.WriteLine("4. Exit");
        Console.Write("Enter the number of the activity you would like to do:");
        string key = Console.ReadKey().KeyChar.ToString();
        switch (key)
        {
            case "1":
                BreathingActivity breathingActivity = new();
                breathingActivity.StartBreathingActivity();
                DisplayMenu();
                break;
            case "2":
                ReflectionActivity reflectionActivity = new();
                reflectionActivity.StartReflectionActivity();
                DisplayMenu();
                break;
            case "3":
                ListingActivity listingActivity = new();
                listingActivity.StartListingActivity();
                DisplayMenu();
                break;
            case "4":
                Environment.Exit(0);
                break;
            default:
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Invalid input. Please enter a number between 1 and 4.");
                DisplayMenu();
                break;
        }
    }
}