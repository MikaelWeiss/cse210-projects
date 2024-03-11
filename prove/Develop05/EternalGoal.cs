using System.ComponentModel;

class EternalGoal(string name, string description, int pointsToComplete) : Goal(name, description, pointsToComplete)
{
    public override int DidCompleteOccurrence()
    {
        return pointsToComplete;
    }
    public override string DisplayStringValue()
    {
        string isCompleteString = isComplete ? "X" : " ";
        return $"[{isCompleteString}] {name} ({description}) - points to complete: {pointsToComplete}";
    }
    public override string StorageString()
    {
        return "EternalGoal~&~" + name + "~~~" + description + "~~~" + pointsToComplete;
    }

    public EternalGoal(string stringValue) : this("", "", 0)
    {
        string[] split = stringValue.Split("~~~");
        name = split[0];
        description = split[1];
        pointsToComplete = Convert.ToInt32(split[2]);
    }
}