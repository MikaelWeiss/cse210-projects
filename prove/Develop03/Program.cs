class Program 
{
    
    static Scripture scripture;

    static void Main(string[] args)
    {
        scripture = new Scripture("Moroni", "10", "32-33", ["Yea,", "come", "unto", "Christ,", "and", "be", "perfected", "in", "him,", "and", "deny", "yourselves", "of", "all", "ungodliness;", "and", "if", "ye", "shall", "deny", "yourselves", "of", "all", "ungodliness,", "and", "love", "God", "with", "all", "your", "might,", "mind", "and", "strength,", "then", "is", "his", "grace", "sufficient", "for", "you,", "that", "by", "his", "grace", "ye", "may", "be", "perfect", "in", "Christ;", "and", "if", "by", "the", "grace", "of", "God", "ye", "are", "perfect", "in", "Christ,", "ye", "can", "in", "nowise", "deny", "the", "power", "of", "God.", "And", "again,", "if", "ye", "by", "the", "grace", "of", "God", "are", "perfect", "in", "Christ,", "and", "deny", "not", "his", "power,", "then", "are", "ye", "sanctified", "in", "Christ", "by", "the", "grace", "of", "God,", "through", "the", "shedding", "of", "the", "blood", "of", "Christ,", "which", "is", "in", "the", "covenant", "of", "the", "Father", "unto", "the", "remission", "of", "your", "sins,", "that", "ye", "become", "holy,", "without", "spot."]);
        DisplayPrompt();
    }

    static void DisplayPrompt() 
    {
        Console.Clear();
        Console.WriteLine(scripture.StringValue());
        Console.Write("Press any key to continue or 'q' to quit");
        string input = Console.ReadKey().KeyChar.ToString().ToLower();
        if (input == "q") {
            Quit();
        } else {
            Continue();
        }
    }

    static void Continue() 
    {
        if (scripture.AllWordsAreHidden()) {
            Quit();
        }
        scripture.HideThreeWords();
        DisplayPrompt();
    }

    static void Quit() 
    {
        Environment.Exit(0);
    }
}