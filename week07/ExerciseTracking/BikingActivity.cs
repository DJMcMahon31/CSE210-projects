using System;

class BikingActivity : Activity
{
    public override string GetSummary()
    {
        return $"{Date.ToShortDateString()}Biking: Distance (km) = {Distance}, Speed (kph): {Speed}, Pace (min per km): {Pace}";
    }
}