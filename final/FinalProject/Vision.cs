class Vision
{
    private List<Goal> goals;

    public List<Goal> GetGoals()
    {
        return goals;
    }

    private string name;

    public string GetName()
    {
        return name;
    }
    private string description;

    public string GetDescription()
    {
        return description;
    }
    void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }
    void RemoveGoal(Goal goal)
    {
        goals.Remove(goal);
    }

    public Vision(string name, string description)
    {
        goals = [];
        this.name = name;
        this.description = description;
    }
    public Vision(string storageString)
    {
        goals = [];
        string[] visionParts = storageString.Split("~~~");
        name = visionParts[0];
        description = visionParts[1];
        string[] goalStrings = visionParts[2].Split("|*|");
        foreach (string goalString in goalStrings)
        {
            Goal newGoal = Goal.GoalFromStorage(goalString);
            goals.Add(newGoal);
        }
    }

    public string StorageStringValue()
    {
        string goalsString = string.Join("|*|", goals.Select(goal => goal.StorageStringValue()));
        return $"{name}~~~{description}~~~{goalsString}";
    }

    // CRUD

    public static Vision CreateVision()
    {
        Console.Clear();
        Console.Write("Enter Vision Name: ");
        string name = Console.ReadLine();
        Console.Write("Enter Vision Description: ");
        string description = Console.ReadLine();

        Vision newVision = new(name, description);
        return newVision;
    }

    public static void DeleteVision(List<Vision> visions)
    {
        if (visions.Count == 0)
        {
            Console.WriteLine("No visions to delete");
            Console.WriteLine();
            Thread.Sleep(1000);
            return;
        }
        Console.WriteLine("Select Vision to Delete");
        for (int i = 0; i < visions.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {visions[i].GetName()}");
        }

        Console.Write("Enter number of vision to delete: ");
        int choice = int.Parse(Console.ReadLine());
        visions.RemoveAt(choice - 1);
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

        Console.WriteLine("Press any key to continue");
        Console.ReadKey();
    }

    public static void SaveVisions(List<Vision> visions)
    {
        string[] stringVisions = visions.Select(vision => vision.StorageStringValue()).ToArray();
        string stringValue = string.Join("~~~|~~~", stringVisions);
        FileManager.WriteToFile(stringValue);
        Console.Clear();
        Console.WriteLine("Visions saved");
        Console.WriteLine();
    }

    public static List<Vision> LoadVisions(List<Vision> visions)
    {
        if (visions.Count != 0)
        {
            Console.Clear();
            Console.WriteLine("Are you sure you want to load visions? (y/n)");
            string choice = Console.ReadKey().KeyChar.ToString();
            if (choice != "y")
            {
                return [];
            }
        }

        string stringValue = FileManager.ReadFromFile();
        string[] stringVisions = stringValue.Split("~~~|~~~");
        List<Vision> newVisions = [];
        foreach (string stringVision in stringVisions)
        {
            Vision newVision = new(stringVision);
            newVisions.Add(newVision);
        }

        Console.Clear();
        Console.WriteLine("Visions loaded");
        Console.WriteLine();

        return newVisions;
    }
}