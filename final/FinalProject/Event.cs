class Event
{
    private DateTime startDate;
    public DateTime GetStartDate()
    {
        return startDate;
    }
    private DateTime endDate;
    public DateTime GetEndDate()
    {
        return endDate;
    }
    private bool isComplete;
    public bool GetIsComplete()
    {
        return isComplete;
    }

    public string DisplayStringValue()
    {
        return $"Start Date: {startDate}, End Date: {endDate}, Is Complete: {isComplete}";
    }

    public string StorageStringValue()
    {
        return $"{startDate}|~/|{endDate}|~/|{isComplete}";
    }

    public Event(DateTime startDate, DateTime endDate, bool isComplete)
    {
        this.startDate = startDate;
        this.endDate = endDate;
        this.isComplete = isComplete;
    }
    public Event(string storageString)
    {
        string[] storageArray = storageString.Split("|~/|");
        startDate = Convert.ToDateTime(storageArray[0]);
        endDate = Convert.ToDateTime(storageArray[1]);
        isComplete = Convert.ToBoolean(storageArray[2]);
    }
}