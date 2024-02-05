using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction one = new Fraction();
        Fraction eight = new Fraction(8);
        Fraction oneHalf = new Fraction(1, 2);
        Fraction newFraction = new Fraction(1, 3);
        newFraction.SetTopNumber(2);
        newFraction.SetBottomNumber(3);
        int newFractionTopNumber = newFraction.GetTopNumber();
        int newFractionBottomNumber = newFraction.GetBottomNumber();

        Console.WriteLine($"top: {newFractionTopNumber}, bottom: {newFractionBottomNumber}");
        string fractionString = newFraction.GetFractionString();
        double fractionValue = newFraction.GetFractionValue();
        Console.WriteLine($"Fraction: {fractionString}, Value: {fractionValue}");
    }
}