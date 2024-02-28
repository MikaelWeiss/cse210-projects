class ReflectionActivity : MindfullnessActivity
{

    private List<string> prompts = [
        "Think of a time when you stood up for someone else",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    ];

    private List<string> reflectionQuestions = [
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    ];

    public void StartReflectionActivity()
    {
        StartActivity();
        DisplayRandomPrompt();
        DisplayReflectionQuestions();
        DisplayActivityEndInformation();
    }
    private void DisplayRandomPrompt()
    {
        Console.Clear();
        string randomPrompt = prompts[new Random().Next(prompts.Count - 1)];
        Console.WriteLine(randomPrompt);
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
        Console.Clear();
    }
    private void DisplayReflectionQuestions()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);

        DateTime currentTime = startTime;
        while (currentTime < futureTime)
        {
            string randomReflectionQuestion = reflectionQuestions[new Random().Next(reflectionQuestions.Count - 1)];
            Console.WriteLine(randomReflectionQuestion);
            DisplaySpinner();
            DisplaySpinner();
            Console.Clear();
            currentTime = DateTime.Now;
        }
    }
    public ReflectionActivity() : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
    }
}