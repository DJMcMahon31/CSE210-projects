using System;

public class ReflectingActivity : Activity
{
    private string _prompts;
    private string _questions;

    public ReflectingActivity(string name, string description, int duration, string prompts, string questions)
        : base(name,description, duration)
    {
        _prompts = prompts;
        _questions = questions;
    }
}
