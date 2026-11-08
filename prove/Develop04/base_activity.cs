class BaseActivity
{
    private string _activityName;
    private string _description;
    private int _duration;
    private DateTime _endTime;

    private int ObtainDuration()
    {
        Console.Write("Enter the session length you'd like (in seconds): ");
        string length = Console.ReadLine();

        int seconds = int.Parse(length);
        return seconds;
    }

    public BaseActivity(string activityName, string description)
    {
        _activityName = activityName;
        _description = description;
    }

    public void StartActivity()
    {
        Console.Clear();

        Console.WriteLine($"Welcome to the {_activityName} activity.");
        Console.WriteLine(_description);

        _duration = ObtainDuration();

        RunSpinnerMessage("Get Ready...", 3);

        StartTimer();
    }

    public void DisplayEnding()
    {
        Console.WriteLine("Congrats!");
        RunSpinnerMessage("You have completed the activity.", 3);
        Console.WriteLine($"You did {_duration} seconds of the activity.");
    }

    public void StartTimer()
    {
        _endTime = DateTime.Now.AddSeconds(_duration);
    }

    public bool HasTimerExpired()
    {
        return DateTime.Now > _endTime;
    }

    protected FlaggedString GetPromptString(List<FlaggedString> prompts)
    {
        bool allUsed = true;

        foreach (FlaggedString prompt in prompts)
        {
            if (!prompt.GetHasBeenUsed())
            {
                allUsed = false;
                break;
            }
        }

        if (allUsed)
        {
            ResetPromptsUsage(prompts);
        }

        Random random = new Random();
        FlaggedString selectedPrompt;

        do
        {
            int index = random.Next(prompts.Count);
            selectedPrompt = prompts[index];
        }
        while (selectedPrompt.GetHasBeenUsed());

        return selectedPrompt;
    }

    protected void ResetPromptsUsage(List<FlaggedString> prompts)
    {
        foreach (FlaggedString prompt in prompts)
        {
            prompt.ResetHasBeenUsed();
        }
    }

    public void RunCountDownMessage(string message, int seconds)
    {
        Console.CursorVisible = false; //removes curser so just the text displays
        for(int i = seconds; i > 0; i--)
        {
            Console.Clear();
            Console.WriteLine($"{message} - {i}");
            Thread.Sleep(1000);
        }
        Console.CursorVisible = true; //brings back the curser to type when the display countdown is done
    }

    public void RunSpinnerMessage(string message, int seconds)
    {
        Console.CursorVisible = false;
        // DateTime now = DateTime.Now;
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        // while(DateTime.Now < endTime)
        // {
        //     Console.Write("+");
        //     Thread.Sleep(200);
        //     Console.Write("\b"); // \b moves the curser back one space
        //     Console.Write("x");
        //     Thread.Sleep(200);
        //     Console.Write("\b");

        // }
        // Console.Clear();
       
        // Console.Write($"{message} ");
        // string spinnerAnimation = "-\\|/";
        // int index = 0;
        // for (int i=0; i<20; i++)
        // {
        //     Console.Write($"{spinnerAnimation[index++ % spinnerAnimation.Length]}");
        //     Console.Write("\b");
        //     Thread.Sleep(300);
        // }
        // Console.Clear();

        // Console.Write($"{message} ");
        // string fishAnimation = "><))))o>";
        // for (int i=0; i<20; i++)
        // {
        //     Console.Write($" {fishAnimation}");
        //     Console.Write("\b\b\b\b\b\b\b\b");
        //     Thread.Sleep(300);
        // }
        // Console.Clear();

        Console.Write($"{message} ");
        string faceAnimation = "(^_^)(-_-)";
        for (int i=0; i<20; i++)
        {
            Console.Write($"{faceAnimation[0..5]}");
            Thread.Sleep(300);
            Console.Write("\b\b\b\b\b");
            Console.Write($"{faceAnimation[5..]}");
            Thread.Sleep(300);
            Console.Write("\b\b\b\b\b");
        }

        Console.CursorVisible = true;
    }

}