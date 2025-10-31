using System;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<int> numbers = new List<int>();
        int number;
        do
        {
            Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
            number = int.Parse(Console.ReadLine()); //18 9 7 0

            if (number != 0)
            {
                numbers.Add(number); //18 9 7
            }



        }
        while (number != 0);

        int sum = 0;
        foreach (var item in numbers)
        {
            sum += item;  
        }

        Console.WriteLine($"The sum is {sum}");
        
        float average = sum / numbers.Count;

        Console.WriteLine($"The average is: {average}");

        int maximum = numbers.Max();

        Console.WriteLine($"The largest number is: {maximum}");

    }
}