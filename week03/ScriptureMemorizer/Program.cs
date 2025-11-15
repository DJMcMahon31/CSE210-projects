using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        Reference reference = new Reference("Nephi", "3","6", "7");
        
        Scripture scripture = new Scripture (reference, "3 Nephi: 6,7. And behold, the third time they did understand the voice which they heard; and it said unto them: Behold my Beloved Son, in whom I am well pleased, in whom I have glorified my name—hear ye him.");

        Console.WriteLine("Here is a scripture to memorize.");

        // Main Loop
        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            //stop if all lines are hidden
            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("All words are hidden, Program ending.");
                break;
            }

            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to stop program.");
            string input = Console.ReadLine().ToLower();

            if (input == "quit")
            {
                Console.WriteLine("Program ended by user.");
                break;
            }


            //Hide 1 random word per loop
            scripture.HideRandomWords(1);
        }

        return;  //this ends the program
       
    }
}

//https://www.churchofjesuschrist.org/study/scriptures/bofm?lang=eng

