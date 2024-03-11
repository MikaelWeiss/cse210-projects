abstract class Shape
{
    private string color;

    public string GetColor() {
        return color;
    }

    public void SetColor(string newColor) {
        color = newColor;
    }

    public abstract double GetArea();
}