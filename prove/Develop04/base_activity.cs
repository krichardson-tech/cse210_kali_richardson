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

        Console.Clear();
       
        Console.Write($"{message} ");
        string spinnerAnimation = "-\\|/";
        int index = 0;
        for (int i=0; i<20; i++)
        {
            Console.Write($"{spinnerAnimation[index++ % spinnerAnimation.Length]}");
            Console.Write("\b");
            Thread.Sleep(300);
        }
        Console.Clear();

        Console.Write($"{message} ");
        string fishAnimation = "><))))o>";
        for (int i=0; i<20; i++)
        {
            Console.Write($" {fishAnimation}");
            Console.Write("\b\b\b\b\b\b\b\b");
            Thread.Sleep(300);
        }
        Console.Clear();

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