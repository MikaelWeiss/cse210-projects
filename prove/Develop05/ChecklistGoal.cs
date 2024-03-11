class ChecklistGoal : Goal
{
    private int timesToComplete;
    private int timesCompleted;
    public override void CheckIfComplete()
    {
        // Check if all the items in the checklist are complete
    }
    public override string DisplayStringValue()
    {
        return "Checklist Goal";
    }
    public override string StorageString()
    {
        return "ChecklistGoal";
    }

    ChecklistGoal(string name, string description, int pointsToComplete, int timesToComplete) : base(name, description, pointsToComplete)
    {
        this.timesCompleted = timesToComplete;
    }
    ChecklistGoal(string stringValue)
    {
        // Parse the string and set the fields
    }
}