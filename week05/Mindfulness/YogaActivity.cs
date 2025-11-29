using System;

public class YogaActivity : Activity
{
    private List<string> _poses;

    public YogaActivity()
        : base("Yoga", "Welcome to the Yoga Activity. This activity will help you use common standing Yoga poses to help relieve tension.", 0)
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

        Console.WriteLine("Get ready for a yoga pose...");
        ShowSpinner(3);
        Console.WriteLine();

        string pose = GetRandomPoses();
        Console.WriteLine($"-_-_- Your pose is: {pose} -_-_-");
        Console.WriteLine("You may begin in:");
        ShowCountDown(5);

        Console.WriteLine();

        Console.WriteLine($"Hold the {pose} for {Duration} seconds...");
        ShowSpinner(Duration);

        Console.WriteLine();
        DisplayEndingMessage();
    }

    private string GetRandomPoses()
    {
        return _poses[_rand.Next(_poses.Count)];
    }
}