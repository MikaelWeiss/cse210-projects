class DisplayManager
{
    public static void DisplayTodaysEvents(List<Vision> visions)
    {
        Console.Clear();
        List<Event> events = [];
        foreach (Vision vision in visions)
        {
            foreach (Goal goal in vision.GetGoals())
            {
                foreach (Event e in goal.EventsToday())
                {
                    events.Add(e);
                }
            }
        }

        foreach (Event e in events)
        {
            Console.WriteLine(e.DisplayStringValue());
        }
        if (events.Count == 0)
        {
            Console.WriteLine("No events today :)");
        }

        Console.WriteLine("Press any key to return to the menu");
        Console.ReadKey();
        Console.Clear();
    }

    public static void DisplayVisions(List<Vision> visions)
    {
        Console.Clear();
        for (int i = 0; i < visions.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {visions[i].GetName()}");
            Console.WriteLine(visions[i].GetDescription());
            Console.WriteLine();
        }

        Console.WriteLine("1. Add Vision");
        if (visions.Count > 0)
        {
            Console.WriteLine("2. View Vision Goals");
            Console.WriteLine("3. Delete Vision");
        }
        Console.WriteLine("Press any key to return to main menu");
        string choice = Console.ReadKey().KeyChar.ToString();
        Console.WriteLine();

        switch (choice)
        {
            case "1":
                Vision newVision = Vision.CreateVision();
                visions.Add(newVision);
                break;
            case "2":
                Console.Write("Enter number of vision to view goals: ");
                int index = int.Parse(Console.ReadKey().KeyChar.ToString()) - 1;
                string visionDisplayString = visions[index].GetName();
                DisplayGoals(visionDisplayString, visions[index].GetGoals());
                break;
            case "3":
                Vision.DeleteVision(visions);
                break;
            default:
                return;
        }

        DisplayVisions(visions);
    }

    private static void DisplayGoals(string visionDisplayString, List<Goal> goals)
    {
        Console.Clear();
        foreach (Goal goal in goals)
        {
            Console.WriteLine(goal.DisplayStringValue());
        }

        if (goals.Count == 0)
        {
            Console.WriteLine("No goals for this vision");
        }

        Console.WriteLine("1. Add Goal");
        if (goals.Count > 0)
        {
            Console.WriteLine("2. Delete Goal");
        }
        Console.WriteLine("Press any key to return to visions");
        string choice = Console.ReadKey().KeyChar.ToString();

        switch (choice)
        {
            case "1":
                Goal newGoal = Goal.CreateGoal();
                goals.Add(newGoal);
                break;
            case "2":
                Console.Write("Enter number of goal to delete: ");
                int index = int.Parse(Console.ReadKey().KeyChar.ToString()) - 1;
                goals.RemoveAt(index);
                break;
            default:
                return;
        }
    }
}