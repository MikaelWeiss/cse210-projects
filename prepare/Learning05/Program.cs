using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square(5);
        square.GetArea();
        square.GetColor();

        Circle circle = new Circle(5);
        circle.GetArea();
        circle.GetColor();

        Rectangle rectangle = new Rectangle(5, 5);
        rectangle.GetArea();
        rectangle.GetColor();

        List<Shape> shapes = [square, circle, rectangle];

        foreach (Shape shape in shapes) {
            Console.WriteLine(shape.GetArea());
            Console.WriteLine(shape.GetColor());
        }
    }
}