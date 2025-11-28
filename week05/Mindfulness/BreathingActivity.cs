using System;

public class BreathingActivity : Activity
{
    private string _breathing;

    public BreathingActivity(string name, string description, int duration, string breathing)
    : base(name, description, duration)
    {
        _breathing = breathing;
    }
}