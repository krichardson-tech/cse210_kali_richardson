using System;

class Program
{
    static void Main(string[] args)
    {
        // BaseActivity activity = new BaseActivity();
        // activity.RunCountDownMessage("Get Ready", 5);
        // activity.RunSpinnerMessage("Well Done", 5);

        BreathingActivity breathingActivity = new BreathingActivity();
        breathingActivity.RunActivity();
    }
}