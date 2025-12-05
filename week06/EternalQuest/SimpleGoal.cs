using System;
using System.Reflection.Metadata.Ecma335;

public class SimpleGoal : Goal
{
    //SimpleGoal gets all fields and methods from Goal, and then adds its own special behaviour
    private bool _isComplete; //this variable stores whether the goal is done.  Only belongs to this class since the other classes work differently

    //this is a constructor which does two important things: calls the base class constructor, and initializes the new field
    public SimpleGoal(string shortName, string description, int points) : base(shortName, description, points)
    {
        _isComplete = false;
    }

    //First override - RecordEvent()
    public override void RecordEvent()  //method - runs when user selects the goal. One time only, just mark as complete
    {
        _isComplete = true;
    }

    //Second override - IsComplete()
    public override bool IsComplete()  //tells other parts ofthe program that the goal is finished
    {
        return _isComplete;
    }

    //Third override - GetDetailsString()
    public override string GetDetailsString()
    {
    string checkbox = _isComplete ? "[X]" : "[ ]";
    return $"{checkbox} {_shortName} ({_description})";  //controls how the goal is shown on the screen
    }

    //Fourth override - GetStringRepresentation()
    public override string GetStringRepresentation()
    {
    return $"SimpleGoal: {_shortName},{_desccription},{_points},{_isComplete}";  //how the goal is written to the save file
    }

}