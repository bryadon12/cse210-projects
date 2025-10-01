using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        fraction1.setNumerator();
        fraction1.setDenominator();
        fraction1.getDecimalValue();
        fraction1.getFractionString();

        Fraction fraction2 = new Fraction(5);
        fraction2.getDecimalValue();
        fraction2.getFractionString();

        Fraction fraction3 = new Fraction(4 / 7);
        fraction3.getDecimalValue();
        fraction3.getFractionString();

        fraction3.setNumerator();
        fraction3.setDenominator();
        fraction3.getDecimalValue();
        fraction3.getFractionString();
    }
}