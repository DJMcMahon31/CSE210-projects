using System;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity(string name, string description, int duration, int count, List<string> prompts)
        : base(name, description, duration)
    {
        _count = count;
        _prompts = prompts;
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
    