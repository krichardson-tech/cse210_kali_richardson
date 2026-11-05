class BreathingActivity : BaseActivity
{
    public void RunActivity()
    {
        // call startActivity() method

        RunCountDownMessage("Get Ready", 5);
        DateTime endTime = DateTime.Now.AddSeconds(40);
        while(DateTime.Now < endTime)
        {
            RunCountDownMessage("Breath In", 4);
            RunCountDownMessage("Hold", 4);
            RunCountDownMessage("Breath Out", 8);
            RunCountDownMessage("Hold", 4);
        }

        // call endActivity()

        
    }
}