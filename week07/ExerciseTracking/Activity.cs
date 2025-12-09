/*
should declare methods for getting the distance, speed, and pace.
should provide a GetSummary method
*/
using System;
using System.Diagnostics.Contracts;

public abstract class Activity
{
    public DateTime Date {get; set; } = DateTime.Now;
    public double Distance {get; set; }
    public double Speed {get; set; }
    public double Pace {get; set; }
    public int Minutes {get; set; }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public abstract string GetSummary();
   
}

