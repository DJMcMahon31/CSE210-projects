using System;

public class ReflectionActivity : Activity
{
    private string _placeholderRA;

    public ReflectionActivity(string placeHolder, string placeholderRA)
        : base(placeHolder)
    {
        _placeholderRA = placeholderRA;
    }
}
