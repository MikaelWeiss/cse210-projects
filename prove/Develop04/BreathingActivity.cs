class BreathingActivity : MindfullnessActivity
{
    public void StartBreathingActivity()
    {
        StartActivity();
        DisplayBreathingInstructions();
        DisplayActivityEndInformation();
    }

    private void DisplayBreathingInstructions()
    {
        bool breathingIn = true;
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);

        DateTime currentTime = startTime;
        while (currentTime < futureTime)
        {
            if (breathingIn)
            {
                Console.WriteLine("Breathe in...");
            }
            else
            {
                Console.WriteLine("Breathe out...");
            }
            breathingIn = !breathingIn;
            DisplayCountdown();
            currentTime = DateTime.Now;
        }
    }

    private void DisplayCountdown()
    {
        for (int i = 1; i < 5; i++)
        {
            Console.Write($"{i}");
            System.Threading.Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }

    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }
}