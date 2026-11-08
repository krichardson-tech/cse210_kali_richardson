class BreathingActivity : BaseActivity
{
    public BreathingActivity(string activityName, string description): base(activityName, description)
    {
    }
    
    public void RunActivity()
    {
        StartActivity();

        while(! HasTimerExpired()) 
        {
            RunCountDownMessage("Breath In", 4);
            RunCountDownMessage("Hold", 4);
            RunCountDownMessage("Breath Out", 8);
            RunCountDownMessage("Hold", 4);
        }

        DisplayEnding();
        
    }
}