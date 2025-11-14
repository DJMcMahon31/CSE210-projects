using System;
using System.Collections.Generic;
using System.Linq;
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
    public string GetDisplayText()
    {
        return $"{_reference}: " + string.Join(" ", _words.Select(w => w.GetDisplayText()));
      
        
    }

    public bool IsCompletelyHidden()
    {
         return _words.All(w => w.IsHidden());
    }

    public void HideRandomWords(int count)
    {
        Random rng = new Random();
        int toHide = Math.Min(count, _words.Count);
        var indices = new HashSet<int>();
        while (indices.Count < toHide)
        {
            indices.Add(rng.Next(0, _words.Count));
        }

        for (int i = 0; i < _words.Count; i++)
        {
            if (indices.Contains(i))
            {
                _words[i].Hide();
            }
            else
            {
                _words[i].Show();
            }
        }
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