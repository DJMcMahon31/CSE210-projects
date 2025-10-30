using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
    }

    {
        Console.WriteLine("What is your grade percentage (without the percentage sign)? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string letter = "";

        if (grade >= 90)
        {
            Console.WriteLine("A");
        }
        else if (grade >= 80)
        {
            Console.WriteLine("B");
        }
        else if (grade >= 70)
        {
            Console.WriteLine("C");
        }
        else if (grade >= 60)
        {
            Console.WriteLine("D");
        }
        else:
        {
            Console.WriteLine("F");
        }
    
        Console.WriteLine($"Your grade is: {letter}");

        if (percent is >= 70)
        {
            Console.WriteLine("You Passed.");
        }

        else 
        {
            Console.WriteLine("Better luck next time.");
        }
    }
}