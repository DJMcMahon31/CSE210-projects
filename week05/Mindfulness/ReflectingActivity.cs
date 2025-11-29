using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you did something really difficult.",
        "Recall a moment when you helped someone in need.",
        "Think of a time when you worked hard to achieve a goal",
        "Remember a time when you remained calm in a stressful situation."
    };
    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful?",
        "What did you learn about yourself?",
        "How did this moment help you grow?",
        "What strengths did you show during this moment?"
    };

    public ReflectingActivity()  //no need to pass lists in the constructor this way. But if you used 'var questions = new List<string>'you would have to pass lists in the constructor.    e.g. 'var activity = new RefectingActivity(prompts,questions);'
        : base("Reflecting","This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of our life.", 0)
    {
    }

//  RANDOM PICK HELPERS
    private string GetRandomPrompt()
    {
        int index = _rand.Next(_prompts.Count);
        return _prompts[index];
    }

    private string GetRandomQuestion()
    {
        int index = _rand.Next(_questions.Count);
        return _questions[index];
    }

//  MAIN START

    public override void Run()
    {
    //Welcome message
        DisplayStartingMessage();  //includes duration input

    //Ask for duration
        /*Console.Write("How long, in seconds, would you like for your session? ");
        Duration = int.Parse(Console.ReadLine());
        Console.WriteLine();*/

    //Get ready spinner
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
        Console.WriteLine(); 
        
        DisplayRandomPrompt();
        DisplayRandomQuestion();
    }

//  DISPLAYING PROMPTS

    public void DisplayRandomPrompt()
    {
        string prompt = GetRandomPrompt();
        
        Console.WriteLine("Consider the following prompt.");
        Console.WriteLine($"-_-_- {prompt} -_-_-");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue. ");
        Console.ReadLine();
        Console.WriteLine("You will be presented with some questions in a few moments.");
        ShowSpinner(3);
    }

//  DISPLAYING QUESTIONS

    public void DisplayRandomQuestion()
    {
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        ShowSpinner(2);
        Console.WriteLine("You may begin in: ");
        ShowCountDown(2);

        DateTime endTime = DateTime.Now.AddSeconds(Duration);

        while (DateTime.Now < endTime)
        {
            string question = GetRandomQuestion();
            Console.WriteLine();
            Console.WriteLine(question);
            Console.WriteLine("Press ENTER when ready for the next question...");
            ShowSpinner(5);
        }

        DisplayEndingMessage();
    }

}
    /*
    "Welcome to the Reflecting Activity.

    This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you hve and how you can use it in other aspects of our life.

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

