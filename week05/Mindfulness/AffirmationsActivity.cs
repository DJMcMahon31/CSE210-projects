using System;

public class AffirmationsActivity : Activity
{
    private string _placeholderAA;

    public AffirmationsActivity(string placeHolder, string placeholderAA)
        : base(placeHolder)
    {
        _placeholderAA = placeholderAA;
    }
}