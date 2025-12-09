using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
    
        double Distance = 4.8;
        double Speed = 3.1;
        double Pace = 8.7;

        Console.WriteLine($"{DateTime.Now.ToShortDateString()} Running (30 min) - Distance {Distance}, Speed {Speed}, Pace: {Pace}");

        Console.WriteLine($"{DateTime.Now.ToShortDateString()} Swimming (30 min) - Distance {Distance}, Speed {Speed}, Pace: {Pace}");

        Console.WriteLine($"{DateTime.Now.ToShortDateString()} Biking (30 min) - Distance {Distance}, Speed {Speed}, Pace: {Pace}");
    }
}