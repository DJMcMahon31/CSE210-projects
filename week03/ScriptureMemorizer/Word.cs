using System;
public class Word
{
    private string _text;
    private bool _IsHidden;

    public Word(string text)
    {
        _text = text;
        _IsHidden = false;
    }

    public void Hide()
    {
        _IsHidden = true;
    }

    public void Show()
    {
        _IsHidden = false;
    }


    public bool IsHidden()
    {
        return _IsHidden;
    }


    public string GetDisplayText()
    {
        return _IsHidden ? new string('_', _text.Length) : _text;
    }
   
    
}
//hidden words

/*
1. Replace the word or letter with a mask
Csharp

Copy code
using System;

class Program
{
    static void Main()
    {
        string text = "The quick brown fox jumps over the lazy dog";
        string wordToHide = "fox";

        // Replace the word with asterisks
        string maskedText = text.Replace(wordToHide, new string('*', wordToHide.Length));

        Console.WriteLine(maskedText);
        // Output: The quick brown *** jumps over the lazy dog
    }
}
*/

/*Csharp

Copy code
using System;

class Program
{
    static void Main()
    {
        string text = "C# allows you to manipulate strings easily.";
        
        // Hide a random word
        string maskedText = HideRandomWord(text);
        
        Console.WriteLine("Original: " + text);
        Console.WriteLine("Masked:   " + maskedText);
    }

    /// <summary>
    /// Hides a random word in the given text by replacing it with asterisks.
    /// </summary>
    static string HideRandomWord(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
            return input; // Return unchanged if empty or null

        // Split into words (basic split on spaces)
        string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        if (words.Length == 0)
            return input;

        // Pick a random index
        Random rand = new Random();
        int index = rand.Next(words.Length);

        // Replace the chosen word with asterisks of the same length
        words[index] = new string('*', words[index].Length);

        // Join back into a sentence
        return string.Join(' ', words);
    }
}
*/