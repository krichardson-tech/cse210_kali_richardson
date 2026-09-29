using System;

class Program
{
    static void Main(string[] args)
    {
//display welcome message
        Console.WriteLine("Welcome to the program!");

//asking for name, fav number, and birth year
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Please enter your favorite number: ");
        int favNumber = int.Parse(Console.ReadLine());

        Console.Write("Please enter the year you were born: ");
        int birthYear = int.Parse(Console.ReadLine());

//finding square number
int sqrNumber = favNumber * favNumber;

//calculate age they are turning this year
int age = DateTime.Now.Year - birthYear;

//displying information
        Console.WriteLine($"{name}, the square of your number is {sqrNumber}.");
        Console.WriteLine($"{name}, you will turn {age} this year.");
    }
}