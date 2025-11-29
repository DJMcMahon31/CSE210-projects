using System;

public class YogaActivity : Activity
{
    private List<string> _poses = new List<string>

    public YogaActivity(string placeHolder, string placeholderAA)
        : base(placeHolder)
    {
        _placeholderAA = placeholderAA;
    }
}