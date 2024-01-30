public class Entry
{
    public string date;
    public string prompt;
    public string response;
    public Entry(string date, string prompt, string response)
    {
        this.date = date;
        this.prompt = prompt;
        this.response = response;
    }

    public string StringValue() {
        // Values seperated by a delimiter
        return $"{date}~:~{prompt}~:~{response}";
    }
}