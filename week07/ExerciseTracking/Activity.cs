/*
should declare methods for getting the distance, speed, and pace.
should provide a GetSummary method
*/
using System;
using System.Diagnostics.Contracts;

public abstract class Activity
{
    public DateTime Date {get; set; } = DateTime.Now;
    public int Minutes {get; set; }

    
    public double Distance => GetDistance();
    public double Speed => GetSpeed();
    public double Pace => GetPace();
    

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public abstract string GetSummary();
   
}

