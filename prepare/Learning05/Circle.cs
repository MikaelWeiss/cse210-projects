class Circle : Shape
{
    private double radius;

    public Circle(double radius) {
        this.radius = radius;
    }

    public override double GetArea() {
        return 3.14 * radius * radius;
    }
}