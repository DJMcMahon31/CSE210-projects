using System;
using System.Threading;


public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", 0)  //constructor
    {
    }

    public override void Run()
    {
    //Welcome message
        Console.Clear();
        Console.WriteLine($"-_-_-Welcome to the {Name} Activity. -_-_-"); 
        Console.WriteLine();
        Console.WriteLine(Description);
        Console.WriteLine();
    

    //Ask for duration
        Console.Write("How long, in seconds, would you like for your session? ");
        Duration = int.Parse(Console.ReadLine());
        Console.WriteLine();

    //Get ready spinner
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
        Console.WriteLine();

    //Breathing loop
        DateTime endTime = DateTime.Now.AddSeconds(Duration);
        while (DateTime.Now < endTime)
        {
            //Breath in
            Console.Write("Breath in... ");
            ShowCountDown(3);
            Console.WriteLine();

            //Breath out
            Console.Write("Breath out... ");
            ShowCountDown(4);
            Console.WriteLine();
            Console.WriteLine();
        }

    //Ending message
            DisplayEndingMessage();
    
   }
}









    //"Welcome to the Breathing Activity.

    //"This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing."

    //"How long, in seconds, would you like for your session?"

    //--"Get ready... "  spinner

    //"Breathe in.....  pause
    //"Now breathe out...  pause

    //"Breathe in ...   pause -- and repeat for set duration - set appropriate duration

    //"Well done!
    //"You have completed another 30 seconds of the Breathing Activity"
