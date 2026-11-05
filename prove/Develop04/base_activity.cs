class BaseActivity
{
    public BaseActivity()
    {
        // COMPLETE
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
        // for(int i = 0; i < seconds; i++)
        while(DateTime.Now < endTime)
        {
            Console.Write("+");
            Thread.Sleep(200);
            Console.Write("\b"); // \b moves the curser back one space
            Console.Write("x");
            Thread.Sleep(200);
            Console.Write("\b");
        }
        Console.CursorVisible = true;
    }

}