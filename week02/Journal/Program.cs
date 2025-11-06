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
        Console.WriteLine("3.Display the Journal");
        Console.WriteLine("4.Save the Journal to a file");
        Console.WriteLine("5.Load the Journal from a file");
        Console.WriteLine("6.Quit");

       
        Console.WriteLine("Choose an option number: ");
        string option = Console.ReadLine();

        if (option == "1")
        {
            //string getPromptGenerator = promptGen.GetRandomPrompt();
            Console.WriteLine(promptGen.GetRandomPrompt());
        }

        if (option == "2")
        {
            myJournal.DisplayAll();
        }

        if (option == "3")
        {
            Console.WriteLine("Save to file option selected.");
        }
        



        
    }   
}