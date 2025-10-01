public class Fraction
{
    private int _numerator;
    private int _denominator;

    public Fraction()
    {

    }

    public Fraction(int wholeNumber)
    {
        _numerator = wholeNumber;
        _denominator = 1;
    }

    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }

    public int getNumerator()
    {
        return _numerator;
    }

        public int getDenominator()
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