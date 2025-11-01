using System;

class Program
{
    static void Main(string[] args)
    //{
    // Console.WriteLine("Hello World! This is the Exercise5 Project.");
    //}

    {
        DisplayMessage();

        string userName = PromptUserName();
        int favNumber = PromptFavNumber();

        double square = CalculateSquare(favNumber);

        DisplayResult(userName, square);
    }
        
    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the Program!");


    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();

        return userName;

    }
    static int PromptFavNumber()
    {
        Console.Write("Please enter your favourite number: ");
        int favNumber = int.Parse(Console.ReadLine());

        return favNumber;
    }

    static double CalculateSquare(int number)
    {
        return number * number;
    }
    
    static void DisplayResult(string userName, double square)
    {    
        Console.WriteLine($"{userName}, the square of your number is {square}");
        
    }
}