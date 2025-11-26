using System;

public class BreathingActivity : Activity
{
    private string _placeholderBA;

    public BreathingActivity(string placeHolder, string placeholderBA)
    : base(placeHolder)
    {
        _placeholderBA = placeholderBA;
    }
}