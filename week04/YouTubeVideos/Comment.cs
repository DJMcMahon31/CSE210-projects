using System;
using System.Runtime.CompilerServices;

public class Comment
{
    private string _name;
    private string _comment;

    public Comment (string name, string comment)
    {
        _name = name;
        _comment = comment;
    }

    public string GetDisplayText()
    {
        return $"Name: {_name}; comment: {_comment}";

    }
}


    
