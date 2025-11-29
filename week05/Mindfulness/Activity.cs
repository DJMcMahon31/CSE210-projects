using System;
using System.Collections.Generic;
using System.Threading;

public abstract class Activity
{
    protected Random _rand = new Random();
    //public string _name;
    //public string _description;
    //public int _duration;

    //showing different ways of using getters and setters

    private string _name;
    public string Name
    {
        get
        {
            return _name;  //return the value
        }
        set
        {
            _name = value;  //assign a new value
        }
    }

    private string _description;
    public string Description
    {
        get{return _description;}
        set{_description = value;}
    }

    public int Duration {get; set;}  //in seconds

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        Duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear(); 
        Console.WriteLine($"-_-_- {Name} -_-_-");
        Console.WriteLine(Description);
        Console.WriteLine();

        Console.WriteLine("How long, in seconds, would you like for your session? ");
        Duration = int.Parse(Console.ReadLine());

        Console.WriteLine("\nPrepare to begin...");
        ShowSpinner(3);
        Console.Clear();
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell Done!");
        ShowSpinner(4);
        Console.WriteLine($"You have completed the {Name} activity for {Duration} seconds.");
        ShowSpinner(4);
    }

    public void ShowSpinner(int seconds)
    {
        /*List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        foreach (string s in animationStrings)*/  //this was causing a problem. replacing it with the code below:

        string[] spinner = { "|", "/", "-", "\\" };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[i % spinner.Length]);
            Thread.Sleep(250);
            Console.Write("\b \b");
            i++;
        }
        
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i> 0; i--)
        {
            Console.Write($"{i} ");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    
    public abstract void Run();  //needs to be implemented in subclasses

}

