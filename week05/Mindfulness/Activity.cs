using System;

public class Activity
{
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
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($" -_-_- {_name} activity -_-_-");
        Console.WriteLine(Description);
        Console.Write("\nEnter the duration (in seconds): ");
    
        Duration = int.Parse(Console.ReadLine());

        Console.WriteLine("\nPrepare to begin...");
        ShowSpinner(5);
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
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        foreach (string s in animationStrings)
        {
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine("Done.");

        //this can also be written as this:
        /*
        public void ShowSpinner(int seconds)
        {
            string[] spinner = {"/", "-", "\\", "|"};
            DateTime end = DateTime.Now.AddSeconds(seconds);
            int i = 0

            while (DateTime.Now < end)
            {
                Console.Write(spinner[i % spinner.Length]);
                Thread.Sleep(200);
                Console.Write("\b");
                i++;
            }
        }
        */
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

