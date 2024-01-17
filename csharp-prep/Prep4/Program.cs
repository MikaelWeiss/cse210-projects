using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        var numbers = new List<int> {1, 2};
        
        foreach(var number in numbers)
        {
            Console.WriteLine($"number is {number}");
        }
    }
}