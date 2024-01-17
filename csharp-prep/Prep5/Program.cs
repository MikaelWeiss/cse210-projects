using System;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        int AddTwo(int number)
        {
            return number + 2;
        }

        int more = AddTwo(10);

        void PrintName(string name)
        {
            Console.WriteLine($"Hello {name}");
        }

        PrintName("Bob");

        var y = 0;
        {
            var w = 10;
            w = y + 4;
            y = 2 + 5;
        }
        
        {
            var w = 10;
            w = y + 4;
            y = 2 + 5;
        }
    }
}