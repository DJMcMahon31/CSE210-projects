using System;

class SwimmingActivity :Activity
{  
    
    private int _laps;

    public SwimmingActivity(int laps, int minutes)
    {
        _laps = laps;
        Minutes = minutes;
    }

    //Distance (km) = swimming laps * 50 / 1000
    public override double GetDistance()
    {
        return _laps * 50/1000; 
    }

    //Speed (mph or kph) = (distance / minutes) * 60
    public override double GetSpeed()
    {
        return (GetDistance() / Minutes) * 60;
    }

    //Pace (min per mile or min per km)= minutes / distance
    public override double GetPace()
    {
        return Minutes / GetDistance();
    }
        public override string GetSummary()
    {
        return $"{DateTime.Now.ToShortDateString()}Swimming ({Minutes} min): Distance: {GetDistance():0.00} km, Speed: {GetSpeed():0.00} kph, Pace: {GetPace():0.00} min/km";
    }


}