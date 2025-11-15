using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
    private static Random rng = new Random();

    public void HideRandomWords(int count)
    {
        //List of words still visible
        var visibleWords = _words.Where(w => !w.IsHidden()).ToList();
        if (visibleWords.Count == 0)
            return;

        int toHide = Math.Min(count, visibleWords.Count);

        //randomly select words to hide
        for (int i = 0; i < toHide; i++)
        {
            int index = rng.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);  //ensures unique selection
        }

    }        
    
}

