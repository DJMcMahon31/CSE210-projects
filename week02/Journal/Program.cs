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

            string filePath = "userText.txt";

            try
            {
                string[] lines = userText.txt;
                foreach (string line in lines)
                {
                    Console.WriteLine(line); //for console applications

                }
            }
            catch (System.Exception)
            {
                Console.WriteLine("An error occurred while reading the file.");
            }


            Console.WriteLine();
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
            Console.WriteLine("Quit option selected.");
        }

        Console.WriteLine ("Thank you for using the Journal Program. Goodbye!"); 
        
    }   
}