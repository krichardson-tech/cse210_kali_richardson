class ListingActivity : BaseActivity
{
    private List<FlaggedString> _prompts;


    public ListingActivity(string activityName, string description): base(activityName, description)
    {
        SetPrompts();
    }

    public void RunActivity()
    {
        StartActivity();

        FlaggedString prompt = GetPromptString(_prompts);

        Console.WriteLine(prompt.GetPrompt());

        int answerCount = 0;
        while (!HasTimerExpired())
        {
            Console.Write("Answer: ");
            Console.ReadLine();
            answerCount++;
        }

        prompt.SetHasBeenUsed();

        Console.WriteLine($"You wrote out {answerCount} responses.");
        DisplayEnding();
    }

    private void SetPrompts()
    {
        _prompts = new List<FlaggedString>
        {
            new FlaggedString("Who are people that you appreciate?", false),
            new FlaggedString("What are personal strengths of yours?", false),
            new FlaggedString("Who are people that you have helped this week?", false),
            new FlaggedString("When have you felt the Holy Ghost this month?", false),
            new FlaggedString("Who are some of your personal heroes?", false)
        };
    }
}