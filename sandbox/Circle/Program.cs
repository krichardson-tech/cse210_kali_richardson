using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        Circle myCircle = new Circle(100);

        // myCircle.SetRadius(10);   -- moved number up and dont need this one anymore do to the constructor we made in circle.cs

        double area = myCircle.GetArea();

        Console.WriteLine(area);
    }
}