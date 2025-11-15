using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        Reference reference = new Reference("Nephi", "3", "6", "7");
        //string text = Console.ReadLine();
        Scripture scripture = new Scripture (reference, "3 Nephi: 6,7. And behold, the third time they did understand the voice which they heard; and it said unto them: Behold my Beloved Son, in whom I am well pleased, in whom I have glorified my name—hear ye him.");

        Console.WriteLine("Here is a scripture to memorize.");
       
        Console.WriteLine(scripture.GetDisplayText()); //shows the whole thing


        // Wait for the user to press Enter once to continue
        Console.WriteLine("Press Enter to continue.");
        Console.ReadLine();

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());

    
        string text = Console.ReadLine();
       
        
    }
}

//https://www.churchofjesuschrist.org/study/scriptures/bofm?lang=eng

