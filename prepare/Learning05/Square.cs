class Square : Shape
{
    private double side;

    public Square(double side) {
        this.side = side;
    }

    public override double GetArea() {
        return side * side;
    }
}