using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        DisplayStartingMessage();

        //Ask for duration
        Console.Write("How long, in seconds, would you like for your session? ");
        Duration = int.Parse(Console.ReadLine());
        Console.WriteLine();

        //Get ready spinner
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
        Console.WriteLine();
        

        Console.WriteLine("List as many responses as you can to the following prompt:");
        string _prompt = GetRandomPrompt();
        Console.WriteLine($"-_-_- {_prompt} -_-_-");
        Console.WriteLine("You may begin in:");
        ShowCountDown(5);

        Console.WriteLine();

    // Start Collecting Items

        _count = GetListFromUser();
        Console.WriteLine();
        Console.WriteLine($"You listed {_count} items!");
        DisplayEndingMessage();

    }

    private string GetRandomPrompt()
    {
        return _prompts[_rand.Next(_prompts.Count)];
    }

    private int GetListFromUser()
    {
        int itemCount = 0;
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        while (stopwatch.Elapsed.TotalSeconds < Duration)
        {
            Console.Write("> ");  //prompt for list item
            Console.ReadLine();
            itemCount++;
        }

        return itemCount;
    }




}
    /*
    "Welcome to the Listing Activity.
    This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.
    How long, in seconds, would you like for your session?
    Get ready...
    spinner
    List as many responses as you can to the following prompt:
     ----When have you felt the Holy Ghost this month? ----
    You may begin in: coundown
     >when I went to the templ
     >this morning reading the scriptures
     >praying last night
     >in sacrament meeting
    You listed 4 items!
    Well done!
    spinner
    You have completed another 20m seconds of the Listing Activity.
    */
    