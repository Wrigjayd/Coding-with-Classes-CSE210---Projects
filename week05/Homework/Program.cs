using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment test = new Assignment("Roberto Rodriguez", "Multiplication");
        Console.WriteLine(test.GetSummary());
        MathAssignment mathTest = new MathAssignment("Roberto Rodriguez", "Multiplication", "Section 7.3", "Problems 8-19");
        Console.WriteLine(mathTest.GetSummary());
        Console.WriteLine(mathTest.GetHomeworkList());
        WritingAssignment writingTest = new WritingAssignment("Roberto Rodriguez", "European History", "The Causes of World War II");
        Console.WriteLine(writingTest.GetSummary());
        Console.WriteLine(writingTest.GetWritingInformation());

    }
}