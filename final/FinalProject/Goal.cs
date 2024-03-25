abstract class Goal
{
    protected List<Event> events;
    protected List<Note> notes;
    public abstract void RecordEvent(Event newEvent);

    /// <summary>
    /// Recurrence is used as a nullable type. If the goal is not recurring, recurrence will be null.
    /// </summary>
    protected Recurrence recurrence;
    public static List<Event> EventsToday(List<Event> events)
    {
        return events.Where(e => (e.GetStartDate() == DateTime.Today) || (e.GetEndDate() == DateTime.Today)).ToList();
    }
}