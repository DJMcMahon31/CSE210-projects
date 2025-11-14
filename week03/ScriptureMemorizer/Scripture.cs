using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
public class Scripture
{
    private Reference _reference;
    private List<Word> _words;


    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        _words = new List<Word>();
        string[] parts = text.Split(" ");
        foreach (string part in parts)
        {
            _words.Add(new Word(part));
        }
    }
    public void GetDisplayText()
    {
        Random rng = new Random();
        foreach (Word w in _words)
        {
            if (rng.Next(1, 100) > difficulty)
            {
                w.Show();
            }
            else
            {
                w.Hide();
            }
            Console.Write(w.GetDisplayText());
            Console.Write(" ");
        }
        
    }

    public bool IsCompletelyHidden()
    {
        return; 
    }

    public void HideRandomWords()
    {
        return;
    }
}

//static void DisplayMessage()

//refer reference class file and word class file
//data type is going to be the class
//reference John 3;16();

/*_words = text.Split("")
                     .Select(word => new Word())*/

        /*HideRandomWords(numberToHide:int) : void;
        GetDisplayText():string;
        IsCompletelyHidden():bool;
        */