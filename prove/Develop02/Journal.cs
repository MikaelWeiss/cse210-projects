using System.Collections.Generic;

public class Journal {
    List<Entry> entries = new List<Entry>();

    public void DisplayEntries() {
            foreach (Entry entry in entries) {
                string[] parts = entry.StringValue().Split("~:~");
                string date = parts[0];
                string prompt = parts[1];
                string response = parts[2];
                Console.WriteLine($"Date: {date}");
                Console.WriteLine($"Prompt: {prompt}");
                Console.WriteLine($"Response: {response}");
                Console.WriteLine(" ---------------------- ");
                Console.WriteLine(" ---------------------- ");
            }
            Console.WriteLine($"Entries Count: {entries.Count}");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
    }

    public void CreateEntry(string date, string prompt, string response) {
        Entry entry = new Entry(date, prompt, response);
        entries.Add(entry);
    }

    // Constructor for a new journal without any entries
    public Journal() { }
    // Constructor for creating a journal from a string of entries
    public Journal(string value)
    {
        var entryStrings = value.Split("&*%i");
        foreach (string entryString in entryStrings)
        {
            string[] parts = entryString.Split("~:~");
            string date = parts[0];
            string prompt = parts[1];
            string response = parts[2];
            CreateEntry(date, prompt, response);
        }
    }
    public string StringValue()
    {
        string stringValue = "";
        for (int i = 0; i < entries.Count; i++)
        {
            stringValue += $"{entries[i].StringValue()}";
            // If it's not the last entry, add a delimiter
            if (i < entries.Count - 1) {
                stringValue += "&*%i";
            }
        }
        return stringValue;
    }
}