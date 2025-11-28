using System;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity(string name, string description, int duration, List<string> prompts, List<string> questions)
        : base(name,description, duration)
    {
        _prompts = prompts;
        _questions = questions;
    }

    /*
    "Welcome to the Reflecting Activity.

    This activity will help you reflect on times in your lif when you have shown strength and resilience. This will help you recognize the power you hve and how you can use it in other aspects of our life.

    How long, in seconds, would you like for your session?"

    "Get ready...
    Consider the following prompt:
    ----Think of a time when you did something really difficult. ----
    When you have something in mind, press enter to continue.  
    Now ponder on each of the following questions as they related to this experience.
    You may begin in:  3 2 1 (countdown)
    >How did you feel when it was complete?  (spinner)
    >What is your favourite thing about this experience? (spinner)  
    Well done! (spinner)
    You have completed another 30 seconds of the Reflecting Activity."
       as an enhancement put in your program a function to not allow duplicate questions until all options have been completed
       
    */
}
