using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
    
        RunningActivity run = new RunningActivity(distance: 4.5, minutes: 30);
        run.Distance = 4.0;
        run.Speed = 2.0;
        run.Pace = 3.0;

        SwimmingActivity swim = new SwimmingActivity(laps: 20, minutes: 30);
        swim.Distance = 1.2;
        swim.Speed = 3.4;
        swim.Pace = 5.6;

        BikingActivity bike = new BikingActivity(distance: 18, minutes: 30);
        bike.Distance = 17.5;
        bike.Speed = 35;
        bike.Pace = 7;

        Console.WriteLine($"{DateTime.Now.ToShortDateString()} Running (30 min) - Distance {run.GetDistance}, Speed {run.GetSpeed}, Pace: {run.GetPace}");

        Console.WriteLine($"{DateTime.Now.ToShortDateString()} Swimming (30 min) - Distance {run.GetDistance}, Speed {run.GetSpeed}, Pace: {run.GetPace}");

        Console.WriteLine($"{DateTime.Now.ToShortDateString()} Biking (30 min) - Distance {run.GetDistance}, Speed {run.GetSpeed}, Pace: {run.GetPace}");
    }
}

/*More streamlined code:

class Program
{
    static void Main(string[] args)
    {
        RunningActivity run = new RunningActivity(distance: 5.0, minutes: 30);
        SwimmingActivity swim = new SwimmingActivity(laps: 20, minutes: 30);
        BikingActivity bike = new BikingActivity(distance: 15.0, minutes: 30);

        Console.WriteLine(run.GetSummary());
        Console.WriteLine(swim.GetSummary());
        Console.WriteLine(bike.GetSummary());
    }
}

*/