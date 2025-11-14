using System;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;
public class Reference
{
    private string _book;
    private string _chapter;
    private string _firstVerse;
    private string _lastVerse;

    public Reference(string book, string chapter, string firstVerse, string lastVerse)
    {
        _book = book;
        _chapter = chapter;
        _firstVerse = firstVerse;
        _lastVerse = lastVerse;

    }  //constructor

    public Reference(string book, string chapter, string firstVerse)
    {
        _book = book;
        _chapter = chapter;
        _firstVerse = firstVerse;
    }

    public string GetDisplayText()
    {
        Console.WriteLine("book");
        Console.WriteLine("chapter");
        Console.WriteLine("firstVerse");
        Console.WriteLine("lastVerse");

        var parts = new List<string>();
        if (!string.IsNullOrEmpty(_book)) parts.Add(_book);
        if (_chapter != null) parts.Add(_chapter.ToString());
        if (!string.IsNullOrEmpty(_firstVerse)) parts.Add(_firstVerse);
        if (!string.IsNullOrEmpty(_lastVerse)) parts.Add(_lastVerse);

        return string.Join(" ", parts);
    }
   
}



