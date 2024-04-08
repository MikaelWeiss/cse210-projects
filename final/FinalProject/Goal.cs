using System.ComponentModel;

abstract class Goal
{
    protected List<Event> events;
    protected List<Note> notes;
    protected GoalType goalType;
    public abstract void RecordEvent(Event newEvent);

    /// <summary>
    /// Recurrence is used as a nullable type. If the goal is not recurring, recurrence will be null.
    /// </summary>
    protected Recurrence recurrence;
    public abstract string DisplayStringValue();
    public abstract string StorageStringValue();
    public List<Event> EventsToday()
    {
        return events.Where(e => (e.GetStartDate() == DateTime.Today) || (e.GetEndDate() == DateTime.Today)).ToList();
    }

    static public Goal CreateGoal()
    {
        Console.Clear();
        Console.WriteLine("1. Outcome Goal");
        Console.WriteLine("2. Process Goal");
        string choice = Console.ReadKey().KeyChar.ToString();
        Console.WriteLine();

        switch (choice)
        {
            case "1":
                return OutcomeGoal.CreateOutcomeGoal();
            case "2":
                return ProcessGoal.CreateProcessGoal();
            default:
                return null;
        }
    }

    static public Goal GoalFromStorage(string storageString)
    {
        string[] storageArray = storageString.Split("||");
        string type = storageArray[0];

        if (type == "OutcomeGoal")
        {
            return new OutcomeGoal(storageString);
        }
        else
        {
            return new ProcessGoal(storageString);
        }
    }
}