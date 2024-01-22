using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        var car = new Car();
        car._model = "Ford";
        Console.WriteLine(car._model);
    }
}

class Car {
    public string _model;
    public string _make;
    public int _year;
    public Color _color;
    public int _gallonsOfGas;
    public int _milesPerGallon;
}