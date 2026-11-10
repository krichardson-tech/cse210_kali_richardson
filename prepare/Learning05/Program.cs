using System;

class Program
{
    static void Main(string[] args)
    {
        Square mySquare = new Square("red", 3);
        Console.WriteLine($"{mySquare.GetColor()}");
        Console.WriteLine($"{mySquare.GetArea()}");
    }
}