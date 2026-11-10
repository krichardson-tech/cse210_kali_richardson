using System;

class Program
{
    static void Main(string[] args)
    {
        // Square mySquare = new Square("red", 3);
        // Console.WriteLine($"{mySquare.GetColor()}");
        // Console.WriteLine($"{mySquare.GetArea()}");

        List<Shape> shapeList = new List<Shape>();
        shapeList.Add(new Square("red", 3));
        shapeList.Add(new Rectangle("red", 3, 4));
        shapeList.Add(new Circle("red", 3));

        foreach(Shape shape in shapeList)
        {
            Console.WriteLine($"Shape: {shape.GetColor()} {shape.GetShapeName()} - Area: {shape.GetArea()}");
        }
    }
}