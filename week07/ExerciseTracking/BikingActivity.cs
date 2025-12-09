using System;

class BikingActivity : Activity
{
    public override string GetSummary()
    {
        return $"Biking: Distance = {Distance}, Speed: {Speed}, Pace: {Pace}";
    }
}