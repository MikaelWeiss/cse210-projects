class ChecklistGoal : Goal
{
    private int timesToComplete;
    private int timesCompleted;
    private int bonus;
    public override int DidCompleteOccurrence()
    {
        if (timesCompleted < timesToComplete)
        {
            timesCompleted++;
            if (timesCompleted == timesToComplete)
            {
                isComplete = true;
                return pointsToComplete + bonus;
            }
        }
        return pointsToComplete;
    }
    public override string DisplayStringValue()
    {
        return "Checklist Goal";
    }
    public override string StorageString()
    {
        return "ChecklistGoal~&~" + name + "~~~" + description + "~~~" + pointsToComplete + "~~~" + timesToComplete + "~~~" + timesCompleted + "~~~" + bonus;
    }

    public ChecklistGoal(string name, string description, int pointsToComplete, int timesToComplete, int bonus) : base(name, description, pointsToComplete)
    {
        this.timesCompleted = timesToComplete;
        this.bonus = bonus;
    }
    public ChecklistGoal(string stringValue) : this("", "", 0, 0, 0)
    {
        string[] split = stringValue.Split("~~~");
        name = split[0];
        description = split[1];
        pointsToComplete = Convert.ToInt32(split[2]);
        timesToComplete = Convert.ToInt32(split[3]);
        timesCompleted = Convert.ToInt32(split[4]);
        bonus = Convert.ToInt32(split[5]);
    }
}