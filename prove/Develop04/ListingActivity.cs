using Microsoft.VisualBasic;

class ListingActivity : MindfullnessActivity
{

    private List<string> prompts = [
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    ];
    public void StartListingActivity()
    {
        StartActivity();
        DisplayRandomPrompt();
        PromptUserToList();
        DisplayActivityEndInformation();
    }
    private void DisplayRandomPrompt()
    {
        string prompt = prompts[new Random().Next(prompts.Count)];
        Console.WriteLine(prompt);
        DisplayCountdown();

    }

    private void DisplayCountdown()
    {
        for (int i = 1; i < 5; i++)
        {
            Console.Write($"{i}");
            System.Threading.Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    private void PromptUserToList()
    {
        Console.WriteLine("Now, take a moment to list as many things as you can think of in the area you just thought about.");
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);

        DateTime currentTime = startTime;
        int count = 1;
        while (currentTime < futureTime)
        {
            Console.Write($"{count}. ");
            Console.ReadLine();
            count++;
            currentTime = DateTime.Now;
        }
    }
    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }
}