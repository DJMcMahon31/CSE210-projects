using System;
using System.Dynamic;

class BikingActivity : Activity
{

    public BikingActivity(double distance, int minutes)
       
    {
        Distance = distance;
        Minutes = minutes;
    }
    public override double GetDistance() => Distance;
    public override double GetSpeed() => (GetDistance() / Minutes) * 60;
    public override double GetPace() => Minutes/GetDistance();
    public override string GetSummary()
    {
       return $"{DateTime.Now.ToShortDateString()}Biking ({Minutes} min): Distance: {GetDistance():0.00} km, Speed: {GetSpeed():0.00} kph, Pace: {GetPace():0.00} min/km";
    }
}