class SimpleGoal(string name, string description, int pointsToComplete) : Goal(name, description, pointsToComplete)
{
    public override int DidCompleteOccurrence()
    {
        isComplete = true;
        return pointsToComplete;
    }
    public override string DisplayStringValue()
    {
        string isCompleteString = isComplete ? "X" : " ";
        return $"[{isCompleteString}] {name} ({description}) - points to complete: {pointsToComplete}";
    }

    public override string StorageString()
    {
        return "SimpleGoal~&~" + name + "~~~" + description + "~~~" + pointsToComplete + "~~~" + isComplete;
    }

    public SimpleGoal(string stringValue) : this("", "", 0)
    {
        string[] split = stringValue.Split("~~~");
        name = split[0];
        description = split[1];
        pointsToComplete = Convert.ToInt32(split[2]);
        isComplete = Convert.ToBoolean(split[3]);
    }
}