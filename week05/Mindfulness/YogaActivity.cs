using System;

public class YogaActivity : Activity
{
    private List<string> _poses;

    public YogaActivity()
        : base("Yoga", ""Welcome to the Yoga Activity. This activity will help you use common standing Yoga poses to help relieve tension.", 0)
    {
        _poses = new List<string>()
        {
            "Mountain Pose",
            "Tree Pose",
            "Extended Triangle Pose",
            "Chair Pose"
        };
    }
    public override void Run()
    {
        DisplayStartingMessage();

        Console.Write("How long, in seconds, would you like for your session? ");
        Duration = int.Parse(Console.ReadLine());
        Console.WriteLine();

        Console.WriteLine("Get ready...");
        ShowSpinner(3);
        Console.WriteLine();

        string _poses = GetRandomPoses();
        Console.WriteLine($"-_-_- {_poses} -_-_-");
        Console.WriteLine("You may begin in:");
        ShowCountDown(5);

        Console.WriteLine();



    }

    private string GetRandomPoses()
    {
        return _poses[_rand.Next(_poses.)];
    }


}