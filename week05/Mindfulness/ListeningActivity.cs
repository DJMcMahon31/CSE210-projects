using System;

public class ListeningActivity : Activity
{
    private string _placeholderLA;

    public ListeningActivity(string placeHolder, string placeholderLA)
        : base(placeHolder)
    {
        _placeholderLA = placeholderLA;
    }
}