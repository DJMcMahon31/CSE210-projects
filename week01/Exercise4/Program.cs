using System;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<int> numbers = new List<int>();  //create a new list.
        int number;  //assign a variable.
        do  //do-while loop.
        {
            Console.WriteLine("Enter a list of numbers, type 0 when finished. "); //print line for user to input data.
            number = int.Parse(Console.ReadLine());   //use Parse to change from string to integer.

            if (number != 0)  //if line to add numbers to list except for the number 0.
            {
                numbers.Add(number); //add the numbers to the list.
            }

        }
        while (number != 0); //while loop to end loop if number entered by user is 0.

        int sum = 0;  //interger variable that equals 0.
        foreach (var item in numbers)  //foreach loop to 
        {
            sum += item;  //equation to add the numbers in the list together. this requires a separate block (curly brackets).
        }

        Console.WriteLine($"The sum is {sum}");  //print the sum.
        
        float average = sum / numbers.Count;  //equation to find the average.

        Console.WriteLine($"The average is: {average}");  //print the average.

        int maximum = numbers.Max();  //equation to find the largest number in the list.

        Console.WriteLine($"The largest number is: {maximum}");  //print the largest number in the list.

    }
}