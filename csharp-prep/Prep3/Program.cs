using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        int count = 5;
        while (count < 10)
            Console.WriteLine($"Count is {count++}");

        int count2 = 5;
        do {
            Console.WriteLine($"Count2 is {count2++}");
        } while (count2 < 10);

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"i is {i}");
        }

        for (int i = 0; i <= 20; i = i + 2)
        {
            Console.WriteLine($"i is {i}");
        }

        string[] colors = { "red", "green", "blue" };

        foreach (string color in colors)
        {
            Console.WriteLine($"color is {color}");
        }

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);
    }
}