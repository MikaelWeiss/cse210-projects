using System;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        int addTwo(int number)
        {
            return number + 2;
        }

        int more = addTwo(10);

        void printName(string name)
        {
            Console.WriteLine($"Hello {name}");
        }
    }
}