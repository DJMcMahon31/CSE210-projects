using System;
public class Fraction
{
    public int Numerator { get; set; }
    public int Denominator { get; set; }

    public Fraction()
    {
        Numerator = 1;
        Denominator = 1;
    }

    public Fraction(int numerator)
    {
        Numerator = numerator;
        Denominator = 1;
    }


    public Fraction(int numerator, int denominator)
    {
        Numerator = numerator;
        Denominator = denominator;
    }

    public override string ToString()
    {
        return $"{Numerator}/{Denominator}";
    }
}