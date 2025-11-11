using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Fractions Project.");

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
        Fraction fraction4 = new Fraction(3, 4);
        Console.WriteLine($"Fraction 4: {fraction4.ToString()}");
        


    }
}