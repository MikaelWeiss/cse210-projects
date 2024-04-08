class ProcessGoal : Goal
{
    private int streak;
    private string desiredProcess;

    public override string DisplayStringValue()
    {
        return $"Desired Process: {desiredProcess}, Streak: {streak}";
    }
    public override string StorageStringValue()
    {
        string eventsString = string.Join("|~|", events.Select(e => e.StorageStringValue()));
        string notesString = string.Join("|~|", notes.Select(n => n.StorageStringValue()));
        return $"ProcessGoal||{goalType}||{recurrence}||{eventsString}||{notesString}||{desiredProcess}||{streak}";
    }
    public override void RecordEvent(Event newEvent)
    {
        if (newEvent.GetIsComplete())
        {
            streak++;
        }
        events.Add(newEvent);
    }

    public ProcessGoal(string desiredProcess, GoalType goalType, Recurrence recurrence)
    {
        this.desiredProcess = desiredProcess;
        this.goalType = goalType;
        this.recurrence = recurrence;
        events = [];
        notes = [];
    }

    public ProcessGoal(string storageString)
    {
        string[] storageArray = storageString.Split("||");
        goalType = (GoalType)Enum.Parse(typeof(GoalType), storageArray[1]);
        recurrence = (Recurrence)Enum.Parse(typeof(Recurrence), storageArray[2]);
        string[] eventStrings = storageArray[3].Split("|~|");
        foreach (string eventString in eventStrings)
        {
            Event newEvent = new(eventString);
            events.Add(newEvent);
        }
        string[] noteStrings = storageArray[4].Split("|~|");
        foreach (string noteString in noteStrings)
        {
            Note newNote = new(noteString);
            notes.Add(newNote);
        }
        desiredProcess = storageArray[5];
        streak = Convert.ToInt32(storageArray[6]);
    }

    // CRUD

    public static ProcessGoal CreateProcessGoal()
    {
        Console.Clear();
        Console.Write("Enter Desired Process: ");
        string desiredProcess = Console.ReadLine();
        Console.Write("Enter Goal Type: ");
        GoalType goalType = (GoalType)Enum.Parse(typeof(GoalType), Console.ReadLine());
        Console.Write("Enter Recurrence: ");
        Recurrence recurrence = (Recurrence)Enum.Parse(typeof(Recurrence), Console.ReadLine());

        ProcessGoal newProcessGoal = new(desiredProcess, goalType, recurrence);
        return newProcessGoal;
    }
}