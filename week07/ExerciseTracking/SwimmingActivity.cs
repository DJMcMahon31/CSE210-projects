using System;

class SwimmingActivity :Activity
{
    public override string GetSummary()
    {
        return $"Swimming: Distance = {Distance}, Speed: {Speed}, Pace: {Pace}";
    }
}