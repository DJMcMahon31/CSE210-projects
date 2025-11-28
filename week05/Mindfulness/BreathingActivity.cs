using System;

public class BreathingActivity : Activity
{
    private string _breathing;

    public BreathingActivity(string name, string description, int duration, string breathing)
    : base(name, description, duration)
    {
        _breathing = breathing;
    }

    //"Welcome to the Breathing Activity.

    //"This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing."

    //"How long, in seconds, would you like for your session?"

    //--"Get ready... "  spinner

    //"Breathe in.....  pause
    //"Now breathe out...  pause

    //"Breathe in ...   pause -- and repeat for set duration - set appropriate duration

    //"Well done!
    //"You have completed another 30 seconds of the Breathing Activity"
}