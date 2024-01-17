using System;

class Program
{
    static void Main(string[] args)
    {
        var newList = new List<int>();
        bool shouldContinue = true;

        while (shouldContinue) {
            Console.Write("Please enter a number: ");
            int number = int.Parse(Console.ReadLine());

            if (number == 0) {
                shouldContinue = false;
                continue;
            }

            newList.Add(number);
        }

        var sum = newList.Sum();
        Console.WriteLine($"The sum is {sum}");

        var average = newList.Average();
        Console.WriteLine($"The average is {average}");

        var largestNumber = newList.Max();
        Console.WriteLine($"The largest number is {largestNumber}");
    }
}