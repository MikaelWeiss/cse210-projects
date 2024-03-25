class OutcomeGoal : Goal
{
    private string desiredOutcome;
    private bool isComplete;
    private DateTime endDate;

    public override void RecordEvent(Event newEvent)
    {
        events.Add(newEvent);
    }
}