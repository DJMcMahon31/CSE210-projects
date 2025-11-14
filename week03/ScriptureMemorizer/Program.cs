using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        Console.WriteLine("Here is a scripture to memorize: ");

        Console.WriteLine("Nephi 3:6-7 And behold, the third time they did understand the voice which they heard; and it said unto them: Behold my Beloved Son, in whom I am well pleased, in whom I have glorified my name—hear ye him.");

        string reference = Console.ReadLine();
        string text = Console.ReadLine();
        Scripture scripture = new Scripture(reference, text);

        Console.WriteLine("\nMemorize this scripture:");
        Console.WriteLine(scripture.GetRenderedText());

        



    }



}

//https://www.churchofjesuschrist.org/study/scriptures/bofm?lang=eng

