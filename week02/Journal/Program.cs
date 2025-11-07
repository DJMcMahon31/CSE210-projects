using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Xml;


class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Journal Project.");

        Journal myJournal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();
       

        Console.WriteLine("1.New Journal Entry");
        Console.WriteLine("2.Display the Journal");
        Console.WriteLine("3.Save the Journal to a file");
        Console.WriteLine("4.Load the Journal from a file");
        Console.WriteLine("5.Quit");

        while (true)

        {
            
            Console.WriteLine("Choose an option number: ");
            int option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                string prompt = promptGen.GetRandomPrompt();
                Console.WriteLine($"Journal Prompt: {prompt}");
                string entryText = Console.ReadLine();
                Console.WriteLine("What is the date today? "); //get date from user
                string date = Console.ReadLine();

                Entry newEntry = new Entry(date, prompt, entryText); //constructor
                myJournal.AddEntry(newEntry);
            }

            else if (option == 2)
            {
                myJournal.DisplayAll();
                
            }

            else if (option == 3)
            {
                Console.WriteLine("Save to file option selected.");
                myJournal.SaveToFile(@"C:\Users\dianne\Documents\BYU Idaho-Pathway\BYUi-CSE210-Programming with Classes\CSE210 wk01-Introduction\CSE210-projects\week02\Journal\journal.txt");
            }

            else if (option == 4)
            {
                Console.WriteLine("Load from file option selected.");
                myJournal.LoadFromFile(@"C:\Users\dianne\Documents\BYU Idaho-Pathway\BYUi-CSE210-Programming with Classes\CSE210 wk01-Introduction\CSE210-projects\week02\Journal\journal.txt");
                myJournal.DisplayAll();
            }

            else if (option == 5)
            {
                Console.WriteLine("Exiting program. Goodbye!");
                break;
            }

            else
            {
                Console.WriteLine("Selection invalid. Please choose a valid option.");
            }
        }
    } 
}