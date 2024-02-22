using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment newAssignment = new Assignment("Samual Bennett", "Multiplication");
        Console.WriteLine(newAssignment.GetSummary());

        MathAssignment newMathAssignment = new MathAssignment("Samual Bennett", "Multiplication", "3.1", "1-10");
        Console.WriteLine(newMathAssignment.GetSummary());
        Console.WriteLine(newMathAssignment.GetHomeworkList());

        WritingAssignment newWritingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(newWritingAssignment.GetWritingInformation());
        Console.WriteLine(newWritingAssignment.GetSummary());
    }
}
