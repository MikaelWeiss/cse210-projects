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
}