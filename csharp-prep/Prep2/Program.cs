using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is you grade percentage?");
        string number = Console.ReadLine();
        int percent = int.Parse(number);

        string grade = "";

        if (percent >= 90)
        {
            grade = "A";
        }
        else if (percent >= 80)
        {
            grade = "B";
        }
        else if (percent >= 70)
        {
            grade = "C";
        }
        else if (percent >= 60)
        {
            grade = "D";
        }
        else 
        {
            grade = "F";
        }

        Console.WriteLine($"Your grade: {grade}");

        if (percent >= 70)
        {
            Console.WriteLine("Congrats! You Passed!");
        }
        else
        {
            Console.WriteLine("Unfortunately you failed, better luck next time.");
        }
    }
}