using System;

public class Fraction
{
    private int numerator;
    private int denominator;

    public Fraction()
    {
        int numberator = 1;
        int denominator = 1;
    }

    public Fraction(int wholeNumber)
    {
        numerator = wholeNumber;
        denominator = 1;
    }

    public Fraction(int _numerator, int _denominator)
    {
        numerator = _numerator;
        denominator = _denominator;
    }

    public string GetFractionString()
    {
        string txt = $"{numerator}/{denominator}";
        return txt;
    }

    public double GetDecimal()
    {
        return (double)numerator / denominator;
    }
}