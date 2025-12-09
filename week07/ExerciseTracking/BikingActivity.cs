using System;
using System.Dynamic;

class BikingActivity : Activity
{

    public BikingActivity(int laps, int minutes)
        base: {_laps, minutes, distance, speed, pace};
    {
        _laps = laps;
        Minutes = minutes;
    }
    public override double GetDistance() => _distance;
    public override double GetSpeed() => (_distance/ Minutes) * 60;
    public override double GetPace() => Minutes / GetDistance;
    public override string GetSummary()
    {
        return $"{Date.ToShortDateString()}Biking: Distance (km) = {Distance}, Speed (kph): {Speed}, Pace (min per km): {Pace}";
    }
}