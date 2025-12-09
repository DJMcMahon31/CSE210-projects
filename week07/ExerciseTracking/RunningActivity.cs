using System;

public class RunningActivity : Activity
{
    public override string GetSummary()
    {
        return $"{Date.ToShortDateString()}Running: Distance (km) = {Distance}, Speed (kph): {Speed}, Pace (min per km): {Pace}";
    }
}