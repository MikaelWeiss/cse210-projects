public abstract class Goal
{
    private string name;
    private string description;
    private bool isComplete;
    private int pointsToComplete;
    public int GetPointsToComplete()
    {
        return pointsToComplete;
    }
    public abstract void CheckIfComplete();
    public abstract string DisplayStringValue();
    public abstract string StorageString();
}