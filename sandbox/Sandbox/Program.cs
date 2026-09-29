using System;

class Program
{
    //FUNCTIONS
    static double AddNumbers(double x, int y)
    {
        return x + y;
    }

    static string MyName()
    {
        return "Bob";
    }

    static void DisplayGreeting(string name)
    {
        Console.WriteLine($"Welcome {name}, it's nice to meet you.");
    }

    static void Main(string[] args)
    {
        string myName = MyName();
        DisplayGreeting(myName);
        double total = AddNumbers(12.234,20);
        Console.WriteLine(total);

        //IF, ELSE & ELSE IF
        // int x = 10;
        // int y = 30;
        // int z = 40;
        // if ((x == 10 || y == 30) && z == 30)
        // {
        //     Console.WriteLine("X is 10");
        //     Console.WriteLine("Y is fun");
        // }
        // else if (x == 20)
        // {
        //     Console.WriteLine("X is 20");
        // }
        // else
        // {
        //     Console.WriteLine("Default Output");
        // }
        
        // WHILE LOOPS
        // bool done = false;
        // while (! done)
        // {
        //     Console.Write("Are we done (y/n)? ");
        //     done = Console.ReadLine() == "y";
        // }

        // DO WHILE
        // bool done;
        // do
        // {
        //     Console.Write("Are we done (y/n)? ");
        //     done = Console.ReadLine().ToLower() == "y"; //.ToLower allows it to work wheather y is capitalized or not (y, Y)
        // } while (! done);


        //FOR LOOPS
        // for(int i = 100000; i > -100000; i-=10000)
        // {
        //     Console.WriteLine(i);
        // }

        //LISTS LIST<int> = NEW LIST<INT>()
        // List<string> myFriends = new List<string> {"Bob", "Betty", "Bubba"};

        // myFriends.Add("Doug");

        // foreach(string friend in myFriends)
        // {
        //     Console.WriteLine(friend);
        // }
    }
}