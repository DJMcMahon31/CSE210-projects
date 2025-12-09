using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
    
        RunningActivity run = new RunningActivity();
        run.Distance = 1.0;
        run.Speed = 2.0;
        run.Pace = 3.0;

        SwimmingActivity swim = new SwimmingActivity();
        swim.Distance = 1.2;
        swim.Speed = 3.4;
        swim.Pace = 5.6;

        BikingActivity bike = new BikingActivity();
        bike.Distance = 17.5;
        bike.Speed = 35;
        bike.Pace = 7;
        
        double Distance = 4.8;
        double Speed = 3.1;
        double Pace = 8.7;

        Console.WriteLine($"{DateTime.Now.ToShortDateString()} Running (30 min) - Distance {Distance}, Speed {Speed}, Pace: {Pace}");

        Console.WriteLine($"{DateTime.Now.ToShortDateString()} Swimming (30 min) - Distance {Distance}, Speed {Speed}, Pace: {Pace}");

        Console.WriteLine($"{DateTime.Now.ToShortDateString()} Biking (30 min) - Distance {Distance}, Speed {Speed}, Pace: {Pace}");
    }
}