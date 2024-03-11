using System;

class Program
{
    static int currentScore;
    static readonly List<Goal> goals = [];

    static void Main(string[] args)
    {
        DisplayMenu();
    }

    private static void DisplayMenu()
    {
        Console.WriteLine("You have " + currentScore + " points");
        Console.WriteLine();
        Console.WriteLine("1. Create Goal");
        Console.WriteLine("2. Display Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");
        Console.WriteLine("Select a choice from the menu: ");
        string option = Console.ReadKey().KeyChar.ToString();
        Console.WriteLine();

        switch (option)
        {
            case "1":
                CreateGoal();
                break;
            case "2":
                DisplayGoals();
                break;
            case "3":
                SaveGoals();
                break;
            case "4":
                LoadGoals();
                break;
            case "5":
                RecordEvent();
                break;
            case "6":
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Invalid option");
                break;
        }
        DisplayMenu();
    }

    private static void CreateGoal()
    {
        Console.Clear();
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Checklist Goal");
        Console.WriteLine("3. Eternal Goal");
        Console.WriteLine("Select a type of goal: ");
        string option = Console.ReadKey().KeyChar.ToString();
        Console.WriteLine();

        Console.WriteLine("Enter the name of the goal: ");
        string name = Console.ReadLine();
        Console.WriteLine("Enter the description of the goal: ");
        string description = Console.ReadLine();
        Console.WriteLine("Enter the points to complete the goal: ");
        int pointsToComplete = Convert.ToInt32(Console.ReadLine());

        switch (option)
        {
            case "1":
                goals.Add(new SimpleGoal(name, description, pointsToComplete));
                break;
            case "2":
                Console.WriteLine("Enter the number of times to complete the goal: ");
                int timesToComplete = Convert.ToInt32(Console.ReadLine());
                Console.Write("What is the bonus for completing the goal: ");
                int bonus = Convert.ToInt32(Console.ReadLine());
                goals.Add(new ChecklistGoal(name, description, pointsToComplete, timesToComplete, bonus));
                break;
            case "3":
                goals.Add(new EternalGoal(name, description, pointsToComplete));
                break;
            default:
                Console.WriteLine("Invalid option");
                break;
        }
        Console.Clear();
        Console.WriteLine("Goal created");
        Console.WriteLine();
    }

    private static void DisplayGoals()
    {
        Console.Clear();
        Console.WriteLine($"Your goal count is: {goals.Count}");
        if (goals.Count == 0)
        {
            Console.WriteLine("You have no goals");
        }
        else
        {
            Console.WriteLine("Your goals are:");
            for (int i = 0; i < goals.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + goals[i].DisplayStringValue());
            }
        }
        Console.WriteLine();
    }

    private static void SaveGoals()
    {
        Console.Clear();
        string stringValue = $"{currentScore}&*&";
        string[] goalStrings = goals.Select(goal => goal.StorageString()).ToArray();
        stringValue += string.Join("~~~|~~~", goalStrings);
        FileManager.WriteToFile(stringValue);
        Console.Clear();
        Console.WriteLine("Goals saved");
        Console.WriteLine();
    }

    private static void LoadGoals()
    {
        Console.Clear();
        string stringValue = FileManager.ReadFromFile();
        string[] split = stringValue.Split("&*&");
        currentScore = Convert.ToInt32(split[0]);
        string[] goalStrings = split[1].Split("~~~|~~~");
        foreach (string goalString in goalStrings)
        {
            string[] fields = goalString.Split("~&~");
            switch (fields[0])
            {
                case "SimpleGoal":
                    goals.Add(new SimpleGoal(fields[1]));
                    break;
                case "ChecklistGoal":
                    goals.Add(new ChecklistGoal(fields[1]));
                    break;
                case "EternalGoal":
                    goals.Add(new EternalGoal(fields[1]));
                    break;
                default:
                    Console.WriteLine("Invalid goal type");
                    break;
            }
        }
        Console.Clear();
        Console.WriteLine("Goals loaded");
        Console.WriteLine();
    }

    private static void RecordEvent()
    {
        Console.Clear();
        Console.WriteLine("Select a goal to record an event for: ");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine(i + ". " + goals[i].DisplayStringValue());
        }
        int option = Convert.ToInt32(Console.ReadLine());
        currentScore += goals[option].DidCompleteOccurrence();
        Console.Clear();
        Console.WriteLine("Event recorded");
        Console.WriteLine();
    }
}