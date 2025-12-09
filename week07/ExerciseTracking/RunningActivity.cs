using System;
using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;

public class RunningActivity : Activity
{
    private double _distance;
    
    public RunningActivity(double distance, int minutes)
    {
        _distance = distance;
        Minutes = minutes;
    }
    public override double GetDistance() => _distance;
    public override double GetSpeed() => (_distance/ Minutes) * 60;
    public override double GetPace() => Minutes / _distance;
    public override string GetSummary()
    {
        return $"{DateTime.Now.ToShortDateString()}Running ({Minutes} min): Distance (km): {GetDistance():0.00} km, Speed: {GetSpeed():0.00} kph, Pace: {GetPace():0.00} min/km";
    }
}