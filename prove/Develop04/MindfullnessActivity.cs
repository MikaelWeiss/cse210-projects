class MindfullnessActivity
{
    private string activityName;
    private string activityDescription;

    protected int duration = 0;

    protected void StartActivity()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the " + activityName + " activity!");
        Console.WriteLine(activityDescription);
        int userInputDuration = AskForDuration();
        duration = userInputDuration;
        DisplayGetReady();
    }

    private void DisplayGetReady()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        DisplaySpinner();
        Console.Clear();
    }

    protected void DisplaySpinner()
    {
        string[] spinnerFrames = ["/", "-", "\\", "|"];
        int frameIndex = 0;

        for (int i = 0; i < 5; i++)
        {
            Console.Write(spinnerFrames[frameIndex]);
            frameIndex = (frameIndex + 1) % spinnerFrames.Length;
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }
    private int AskForDuration()
    {
        Console.WriteLine("How long, in seconds would you like for your session?");
        int duration = Convert.ToInt32(Console.ReadLine());
        return duration;
    }
    public void DisplayActivityEndInformation()
    {
        Console.Clear();
        Console.WriteLine("Well done!!");
        DisplaySpinner();
        Console.WriteLine($"You have completed another {duration} seconds of the {activityName} activity!");
        DisplaySpinner();
        Console.Clear();
    }
    public MindfullnessActivity(string name, string description)
    {
        activityName = name;
        activityDescription = description;
    }
}