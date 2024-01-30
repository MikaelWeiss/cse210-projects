using System;
using System.Collections.Generic;


class Program
{
    static List<String> prompts = new List<String>() {
        "What is something meaningful that happened today?",
        "What is something that you learned today?",
        "What is something that you are grateful for today?",
        "What is something that you are looking forward to?",
        "What is something that you are struggling with?",
        "What is something that you are proud of?",
        "What is something that you are excited about?",
        "What is something that you are worried about?",
        "How are you feeling today?",
        "How are you doing today?",
        "If you could change one thing about today, what would it be?",
        "If you could relive one moment from today, what would it be?",
        "If you could change one thing about your life, what would it be?",
        "What actions will you take today to make your life better?",
        "What actions will you take today to make someone else's life better?",
        "Who is someone that you are grateful for?",
        "Who is someone around you that needs help?",
        "What is something meaningful you can do for someone else today?",
        "What is something meaninful that someone else did for you today?",
        "What is a goal that you have for today?",
        "What is a habit that you want to start today?"
    };
    static Journal journal = new Journal();
    static void Main(string[] args)
    {
        Console.Clear();
        DisplayMenu();
    }

    static void DisplayMenu()
    {
        Console.WriteLine("1. Create a new journal entry");
        Console.WriteLine("2. Display all journal entries");
        Console.WriteLine("3. Save journal to file");
        Console.WriteLine("4. Load journal from file");
        Console.WriteLine("5. Exit");
        Console.Write("What would you like to do? (1-5) ");
        string input = Console.ReadKey().KeyChar.ToString();
        Console.WriteLine();
        switch (input)
        {
            case "1":
                Console.Clear();
                var prompt = RandomPrompt();
                var response = AskForResponseToPrompt(prompt);
                var date = DateTime.Now.ToShortDateString();
                journal.CreateEntry(date, prompt, response);
                break;
            case "2":
                Console.Clear();
                journal.DisplayEntries();
                Console.Clear();
                break;
            case "3":
                FileManager.WriteToFile(journal.StringValue());
                break;
            case "4":
                var stringValue = FileManager.ReadFromFile();
                journal = new Journal(stringValue);
                break;
            case "5":
                Console.Clear();
                Environment.Exit(0);
                return;
            default:
                Console.WriteLine("Invalid input");
                break;
        }
        Console.Clear();
        DisplayMenu();
    }

    static string AskForResponseToPrompt(string prompt)
    {
        Console.WriteLine(prompt);
        string response = Console.ReadLine();
        
        return response;
    }
    static string RandomPrompt()
    {
        Random random = new Random();
        int randomIndex =  random.Next(0, prompts.Count - 1);
        string randomElement = prompts[randomIndex];
        return randomElement;
    }
}