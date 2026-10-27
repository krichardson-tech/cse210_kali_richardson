using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment myAssignement = new Assignment("Stacy Black", "Quadratic Formula");
        Console.WriteLine(myAssignement.GetSummary());
        Console.WriteLine("");

        MathAssignment myMathAssignement = new MathAssignment("Stacy Black", "Quadratic Formula", "2.3", "5-35 Even");
        Console.WriteLine(myMathAssignement.GetHomeworkList());
        Console.WriteLine("");

        WritingAssignment myWritingAssignement = new WritingAssignment("Stacy Black", "European History", "The Causes of World War II");
        Console.WriteLine(myWritingAssignement.GetWritingInformation());
    }
}