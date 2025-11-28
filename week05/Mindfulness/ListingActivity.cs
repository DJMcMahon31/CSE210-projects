using System;

public class ListingActivity : Activity
{
    private int _count;
    private string _prompts;

    public ListingActivity(string name, string description, int duration, int count, string prompts)
        : base(name, description, duration)
    {
        _count = count;
        _prompts = prompts;
    }

    //Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
}