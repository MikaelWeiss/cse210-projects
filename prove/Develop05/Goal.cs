abstract class Goal(string name, string description, int pointsToComplete)
{
    protected string name = name;
    protected string description = description;
    protected bool isComplete;
    protected int pointsToComplete = pointsToComplete;
    public abstract int DidCompleteOccurrence();
    public abstract string DisplayStringValue();
    public abstract string StorageString();
}