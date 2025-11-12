using System;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;
public class Reference
{
    private string _lastVerse;
    private string _firstVerse;
    private string _chapter;
    private string _book;

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

    public void Display()
    {
        Console.WriteLine("book");
        Console.WriteLine("chapter");
        Console.WriteLine("firstVerse");
        Console.WriteLine("lastVerse");
    }
    /*
    or:
        public string Display()
{
    // Build the reference string
    if (!string.IsNullOrEmpty(_lastVerse))
    {
        return $"{_book} {_chapter}:{_firstVerse}-{_lastVerse}";
    }
    else
    {
        return $"{_book} {_chapter}:{_firstVerse}";
    }
    */
}



