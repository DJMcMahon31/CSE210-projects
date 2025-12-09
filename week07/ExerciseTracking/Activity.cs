/*
should declare methods for getting the distance, speed, and pace.
should provide a GetSummary method
*/
using System;

public abstract class Activity
{
    public double Distance {get; set; }
    public double Speed {get; set; }
    public double Pace {get; set; }

    public string GetSummary();
   
}

