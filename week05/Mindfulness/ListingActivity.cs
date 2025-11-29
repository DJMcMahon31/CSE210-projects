using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Runtime.CompilerServices;
public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity()
        : base("Listing", "Welcome to the Listing Activity. This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 0)
    {
        _prompts = new List<string>()
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "What are some of your favorite memories?"
        };
    }

    public override void Run()
    {
        //Welcome message
        DisplayStartingMessage();  //includes duration

        //Get ready spinner
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
        Console.WriteLine();
        
        string prompt = GetRandomPrompt();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"-_-_- {prompt} -_-_-");
        Console.WriteLine("You may begin in:");
        ShowCountDown(5);

        Console.WriteLine();

        int itemCount = 0;
        DateTime endTime = DateTime.Now.AddSeconds(Duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");  //prompt for list item
            Console.ReadLine();
            itemCount++;
        }
        Console.WriteLine($"\nYou listed {itemCount} items");

        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        return _prompts[_rand.Next(_prompts.Count)];
    }
}
    