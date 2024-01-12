using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please write a grade percentage: ");
        string input = Console.ReadLine();
        int grade = int.Parse(input);
        string letterGrade = "";

        if (grade >= 90)
        {
            letterGrade = "A";
            if (grade <= 92)
            {
                letterGrade += "-";
            }
        }
        else if (grade >= 80)
        {
            letterGrade = "B";

            if (grade >= 87)
            {
                letterGrade += "+";
            }
            else if (grade <= 82)
            {
                letterGrade += "-";
            }
        }
        else if (grade >= 70)
        {
            letterGrade = "C";

            if (grade >= 77)
            {
                letterGrade += "+";
            }
            else if (grade <= 72)
            {
                letterGrade += "-";
            }
        }
        else if (grade >= 60)
        {
            letterGrade = "D";

            if (grade >= 67)
            {
                letterGrade += "+";
            }
            else if (grade <= 62)
            {
                letterGrade += "-";
            }
        }
        else
        {
            letterGrade = "F";
        }

        Console.WriteLine($"Your letter grade is {letterGrade}");

        if (grade >= 70)
        {
            Console.WriteLine("Congrats! You passed!");
        }
        else
        {
            Console.WriteLine("So sorry. You failed! Keep trying! You'll get it!");
        }
    }
}