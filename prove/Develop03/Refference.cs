public class Reference 
{
    private string book;
    private string chapter;
    private string verses;

    public string StringValue()
    {
        return $"{book} {chapter}:{verses}";
    }

    public Reference(string book, string chapter, string verses)
    {
        this.book = book;
        this.chapter = chapter;
        this.verses = verses;
    }
}