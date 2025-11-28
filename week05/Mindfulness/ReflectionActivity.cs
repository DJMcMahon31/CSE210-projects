using System;

public class ReflectionActivity : Activity
{
    private string _prompts;
    private string _questions;

    public ReflectionActivity(string name, string description, int duration, string prompts, string questions)
        : base(name,description, duration)
    {
        _prompts = prompts;
        _questions = questions;
    }
}
