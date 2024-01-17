using System;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        var name = PromptUserName();
        var number = PromptUserNumber();
        DisplayResult(name, number);
    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        var name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write($"Please enter your favorite number: ");
        var number = int.Parse(Console.ReadLine());

        return number;
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }

    static void DisplayResult(string name, int number) {
        var squaredNumber = SquareNumber(number);

        Console.WriteLine($"Hello {name}, the square of your number is {squaredNumber}");
    }
}