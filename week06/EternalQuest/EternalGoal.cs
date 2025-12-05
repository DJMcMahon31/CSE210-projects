using System;
using System.ComponentModel;

public class EternalGoal : Goal;

//This is a goal that you never finish.

//EternalGoal inherits: shortName, description,and points. --Inheritance
//It overrides: RecordEvent(), IsComplete(), GetDetailsSpring(), and GetStringRepresentation(). --Polymorphism

{
    public EternalGoal(string shortName, string description, int points)  //constructor - sends name, description, and points to the base class 'Goal.cs'; Eternal goals do not need extra fields; they behave the same forever, so no need for bonus, target, etc.

        :base(shortName, Description, points)
    {
    }

    //First override - RecordEvent()
    //everytime he user performs th eternal goal (e.g. read scriptures), this method is called.
    //It does not mark anything as complete, because eternal goals never end.
    //Points are still rewarded, usually by GoalManageer.

    public override void RecordEvent()
    {
        //Eternal goals never complete; they just give points each time.
        Console.WriteLine($"Event recorded for {_shortName}!");
    }

    //Second override - IsComplete()
    /*
     This is the defining rule.
        An eternal goal is never complete.
        This is why:
        The menu always shows it as incomplete
        You can select it unlimited times
        It behaves differently from SimpleGoal and ChecklistGoal
        This is also why EternalGoal has no special fields.
    */
    public override bool IsComplete()
    {
        return false;
    } 

    //Third override - GetDetailsString()
    /*
        This is the display format
        thee symbol (infinity) is an easy way to visually show "never ending"
    */ 

    public override string GetDetailsString()
    {
        return $"[] {_shortName} ({description})";
    }
    
    //Fourth override - GetStringRepresentation()
     //This is how the goal is saved in the text file.
     //Unlike ChecklistGoal, EternalGoal does not need bonus, target, or amountCompleted.

    public override string GetStringRepresentation()
    {
    //Format for saving: EternalGoal: shortName, description, points
        return $"EternalGoal: {_shortName}, {_description}, {_points}";
    }
}

/*
EternalGoal is:
infinite
repeatable
never complete
always awards points
It is the simplest subclass — no extra fields, no progress tracking.
It relies entirely on polymorphism:
even though you treat it like any Goal, its overridden methods give it unique behavior.
*/



