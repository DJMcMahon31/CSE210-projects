using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Exercise3 Project.");
        
        Console.Write("What is the magic number? ");
        int magic = int.Parse(Console.ReadLine());
        int guess = -1;

        while (guess != magic)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());


            if (guess < magic)
            {
                Console.WriteLine("Higher");
            }

            else if (guess > magic)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
            
        }
    }

    
}