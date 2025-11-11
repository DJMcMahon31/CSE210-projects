using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Fractions Project.");

        /*
        //create an instance of the first constructor (1/1)
        Fraction fraction1 = new Fraction();
        Console.WriteLine($"Fraction 1: {fraction1}");

        //create an instance of the second constructor (top/1)
        Fraction fraction2 = new Fraction(6);
        Console.WriteLine($"Fraction 2: {fraction2}");

        //create an instance of the third constructor (top/bottom)
        Fraction fraction3 = new Fraction(6, 7);
        Console.WriteLine($"Fraction 3: {fraction3}");

        //create a method called GetFractionString that returns the fraction in the form 3/4.
        Fraction GetFractionString = new Fraction(3, 4);
        Console.WriteLine($"Fraction 4: {GetFractionString.ToString()}");

        //create a method called GetDecimalValue that returns a double that is the result of dividing the top number by the bottom number, such as 0.75.
        double GetDecimalValue = (double)GetFractionString.Numerator / GetFractionString.Denominator;
        Console.WriteLine($"Decimal Value of Fraction 4: {GetDecimalValue}");
        */

        //display the different representations for a few different fractions.
        Fraction fraction5 = new Fraction(1, 1);
        Console.WriteLine(fraction5.GetFractionString());
        Console.WriteLine(fraction5.GetDecimalString());

        Fraction fraction6 = new Fraction(5, 1);
        Console.WriteLine(fraction6.GetFractionString());
        Console.WriteLine(fraction6.GetDecimalString());

        Fraction fraction7 = new Fraction(3, 4);
        Console.WriteLine(fraction7.GetFractionString());
        Console.WriteLine(fraction7.GetDecimalString());

        Fraction fraction8 = new Fraction(1, 3);
        Console.WriteLine(fraction8.GetFractionString());
        Console.WriteLine(fraction8.GetDecimalString());
    }
}