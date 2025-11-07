using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Journal Project.");

        Journal myJournal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();
        Entry newEntry = new Entry();

        Console.WriteLine("1.New Journal Entry");
        Console.WriteLine("2.Display the Journal");
        Console.WriteLine("3.Save the Journal to a file");
        Console.WriteLine("4.Load the Journal from a file");
        Console.WriteLine("5.Quit");

    while (true)


        Console.WriteLine("Choose an option number: ");
        string option = Console.ReadLine();

        if (option == "1")
        {
            //string getPromptGenerator = promptGen.GetRandomPrompt();
            Console.WriteLine(promptGen.GetRandomPrompt());
            string userEntry = Console.ReadLine();

            string entryText = "user_entry.txt";

            Console.WriteLine($"Message saved to {entryText}");


        }

        else if (option == "2")
        {
            myJournal.DisplayAll();
        }

        else if (option == "3")
        {
            Console.WriteLine("Save to file option selected.");
        }

        else if (option == "4")
        {
            Console.WriteLine("Load from file option selected.");
        }

        else if (option == "5")
        {
            Console.WriteLine("Exiting program. Goodbye!");
        }

        Console.WriteLine ("Selection invalid. Please choose a valid option."); 
        
    }   
}