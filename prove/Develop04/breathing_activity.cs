class BreathingActivity : BaseActivity
{
    public BreathingActivity(): base()
    {
        
    }
    
    public void RunActivity()
    {
        // call startActivity() method
        RunCountDownMessage("Get Ready", 5);
        StartTimer();
        // DateTime endTime = DateTime.Now.AddSeconds(20); 
        // while(DateTime.Now < endTime) 
        while(! HasTimerExpired()) 
        {
            RunCountDownMessage("Breath In", 4);
            RunCountDownMessage("Hold", 4);
            RunCountDownMessage("Breath Out", 8);
            RunCountDownMessage("Hold", 4);
        }

        // call endActivity()

        
    }
}