using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
    
        RunningActivity run = new RunningActivity(distance: 4.5, minutes: 30);
        

        SwimmingActivity swim = new SwimmingActivity(laps: 20, minutes: 30);
        

        BikingActivity bike = new BikingActivity(distance: 18, minutes: 30);
       

        Console.WriteLine(swim.GetSummary());

        Console.WriteLine(bike.GetSummary());

        Console.WriteLine(run.GetSummary());
    }
}

/*More streamlined code:

class Program
{
    static void Main(string[] args)
    {
        RunningActivity run = new RunningActivity(distance: 5.0, minutes: 30);
        SwimmingActivity swim = new SwimmiConsolengActivity(laps: 20, minutes: 30);
        BikingActivity bike = new BikingActivity(distance: 15.0, minutes: 30);

        Console.WriteLine(run.GetSummary());
        Console.WriteLine(swim.GetSummary());
        Console.WriteLine(bike.GetSummary());
    }
}

*/
 /*For future reference:
 Console.WriteLine($"{DateTime.Now.ToShortDateString()} Swimming (30 min) - Distance {swim.GetDistance()}, Speed {swim.GetSpeed()}, Pace: {swim.GetPace()}");
        */