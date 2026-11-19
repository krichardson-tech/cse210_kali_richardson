using System;

class Program
{
    static void Main(string[] args)
    {
        // be sure to add the current point amount above the menu cause i didnt put it with the menu
        
        BaseGoal myGoal = new BaseGoal("BaseGoal");
        Console.WriteLine(myGoal.GetConsoleString());
    }
}