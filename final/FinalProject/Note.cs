class Note
{
    private string Text { get; set; }
    private DateTime Date { get; set; }
    public Note(string text, DateTime date)
    {
        Text = text;
        Date = date;
    }
    public string StringValue()
    {
        return $"{Date.ToShortDateString()}: {Text}";
    }
    public Note(string storageString)
    {
        if (storageString == "")
        {
            return;
        }
        string[] storageArray = storageString.Split("|~%|");
        Date = Convert.ToDateTime(storageArray[0]);
        Text = storageArray[1];
    }
    public string StorageStringValue()
    {
        return $"{Date}|~%|{Text}";
    }
}