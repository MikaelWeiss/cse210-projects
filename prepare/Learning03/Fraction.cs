public class Fraction
{
    private int topNumber;

    public int GetTopNumber()
    {
        return topNumber;
    }

    public void SetTopNumber(int value)
    {
        topNumber = value;
    }
    private int bottomNumber;

    public int GetBottomNumber()
    {
        return bottomNumber;
    }

    public void SetBottomNumber(int value)
    {
        bottomNumber = value;
    }

    public Fraction()
    {
        this.topNumber = 1;
        this.bottomNumber = 1;
    }

    public Fraction(int topNumber)
    {
        this.topNumber = topNumber;
        this.bottomNumber = 1;
    }

    public Fraction(int topNumber, int bottomNumber)
    {
        this.topNumber = topNumber;
        this.bottomNumber = bottomNumber;
    }

    public string GetFractionString()
    {
        return $"{topNumber}/{bottomNumber}";
    }

    public double GetFractionValue()
    {
        return (double)topNumber / bottomNumber;
    }
}