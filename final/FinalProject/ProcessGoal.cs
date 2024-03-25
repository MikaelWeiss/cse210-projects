class ProcessGoal : Goal
{
    private int streak;
    private string desiredProcess;

    public override void RecordEvent(Event newEvent)
    {
        if (newEvent.GetIsComplete())
        {
            streak++;
        }
        events.Add(newEvent);
    }
}