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

    public OutcomeGoal(string desiredOutcome, DateTime endDate, GoalType goalType, RecurrenceType recurrence)
    {
        this.desiredOutcome = desiredOutcome;
        this.endDate = endDate;
        this.goalType = goalType;
        this.recurrence = recurrence;
        isComplete = false;
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
        return $"OutcomeGoal||{goalType}||{recurrence}||{eventsString}||{notesString}||{desiredOutcome}||{endDate}||{isComplete}";
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
        Console.WriteLine("Select Goal Type:");
        foreach (GoalType type in Enum.GetValues(typeof(GoalType)))
        {
            Console.WriteLine($"{(int)type}. {type}");
        }
        int goalTypeNumber = Convert.ToInt32(Console.ReadLine());
        GoalType selectedGoalType = (GoalType)goalTypeNumber;
        Console.WriteLine("Select Recurrence:");
        foreach (RecurrenceType recurrenceType in Enum.GetValues(typeof(RecurrenceType)))
        {
            Console.WriteLine($"{(int)recurrenceType}. {recurrenceType}");
        }
        int recurrenceNumber = Convert.ToInt32(Console.ReadLine());
        RecurrenceType recurrence = (RecurrenceType)recurrenceNumber;
        OutcomeGoal newOutcomeGoal = new(desiredOutcome, endDate, selectedGoalType, recurrence);
        return newOutcomeGoal;
    }

    public OutcomeGoal(string storageString)
    {
        events = [];
        notes = [];

        string[] storageArray = storageString.Split("||");
        goalType = (GoalType)Enum.Parse(typeof(GoalType), storageArray[1]);
        recurrence = (RecurrenceType)Enum.Parse(typeof(RecurrenceType), storageArray[2]);
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

        desiredOutcome = storageArray[5];

        endDate = Convert.ToDateTime(storageArray[6]);

        isComplete = Convert.ToBoolean(storageArray[7]);
    }
}