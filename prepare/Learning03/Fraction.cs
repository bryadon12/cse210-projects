public class Fraction
{
    private float _numerator;
    private float _denominator;

    public Fraction()
    {

    }

    public Fraction(float wholeNumber)
    {
        _numerator = wholeNumber;
        _denominator = 1;
    }

    public Fraction(float numerator, float denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }

    public float getNumerator()
    {
        return _numerator;
    }

    public float getDenominator()
    {
        return _denominator;
    }
    public void setNumerator()
    {
        Console.WriteLine("Enter the Numerator.");
        _numerator = int.Parse(Console.ReadLine());
    }

    public void setDenominator()
    {
        Console.WriteLine("Enter the Denominator.");
        _denominator = int.Parse(Console.ReadLine());
    }

    public void getFractionString()
    {
        Console.WriteLine($"{_numerator}/{_denominator}");
    }

    public void getDecimalValue()
    {
        Console.WriteLine(_numerator / _denominator);
    }
}