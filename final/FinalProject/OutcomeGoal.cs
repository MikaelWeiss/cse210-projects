using System.ComponentModel;

class OutcomeGoal : Goal
{
    private string desiredOutcome;
    private bool isComplete;
    private DateTime endDate;

    public override void RecordEvent(Event newEvent)
    {
        events.Add(newEvent);
    }

    public OutcomeGoal(string desiredOutcome, DateTime endDate, GoalType goalType, Recurrence recurrence)
    {
        this.desiredOutcome = desiredOutcome;
        this.endDate = endDate;
        this.goalType = goalType;
        this.recurrence = recurrence;
        events = [];
        notes = [];
    }

    public override string DisplayStringValue()
    {
        return $"Outcome Goal. Desired Outcome: {desiredOutcome}, End Date: {endDate}";
    }

    public override string StorageStringValue()
    {
        string eventsString = string.Join("|~|", events.Select(e => e.StorageStringValue()));
        string notesString = string.Join("|~|", notes.Select(n => n.StorageStringValue()));
        return $"OutcomeGoal||{goalType}||{recurrence}||{eventsString}||{notesString}||{desiredOutcome}||{endDate}";
    }

    // CRUD

    public static OutcomeGoal CreateOutcomeGoal()
    {
        Console.Clear();
        Console.Write("Enter Desired Outcome: ");
        string desiredOutcome = Console.ReadLine();
        Console.Write("Enter End Date: ");
        DateTime endDate = Convert.ToDateTime(Console.ReadLine());
        Console.Write("Enter Goal Type: ");
        GoalType goalType = (GoalType)Enum.Parse(typeof(GoalType), Console.ReadLine());
        Console.Write("Enter Recurrence: ");
        Recurrence recurrence = (Recurrence)Enum.Parse(typeof(Recurrence), Console.ReadLine());

        OutcomeGoal newOutcomeGoal = new(desiredOutcome, endDate, goalType, recurrence);
        return newOutcomeGoal;
    }

    public OutcomeGoal(string storageString)
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
        desiredOutcome = storageArray[4];
        endDate = Convert.ToDateTime(storageArray[5]);
    }
}