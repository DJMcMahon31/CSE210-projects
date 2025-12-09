using System;

class SwimmingActivity :Activity
{
    public override string GetSummary()
    {
        return $"{Date.ToShortDateString()}Swimming: Distance (km) = {Distance}, Speed (kph): {Speed}, Pace (min per km): {Pace}";
    }


}