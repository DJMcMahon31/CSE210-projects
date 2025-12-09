using System;

public class RunningActivity : Activity
{
    public override string GetSummary()
    {
        return $"Running: Distance = {Distance}, Speed: {Speed}, Pace: {Pace}";
    }
}