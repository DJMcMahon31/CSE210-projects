using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

public class Video
{
    private string _title;
    private string _author;
    private int _length;

    public Video (string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public string GetDisplayText()
    {
        return $"{_title} by {_author} ({_length} seconds)";
    }


}
