using System;
using System.Runtime.ExceptionServices;
/*
A Checklist Goal: must be completed multiple times, each completion gives points, after finishing the required number of times, you get a bonus reward.
A Checklist Goal needs to store: required number of times, how many times have been completed, bonus points, normal points earned each time, and name + description (from the base class)
*/

public class CheckListGoal : Goal
//receives automatically(_shortName, _description, _points) and abstract methods to override
{
    private int _amountCompleted;  //how many times you've done the goal so far
    private int _target;           //the number needed to finish
    private int _bonus;            //extra points given once the goal is fully complete
    // these are unique to the CheckListGoal - other goal types do not use them.

    public CheckListGoal(string shortName, string description, string points, int amountCompleted, int target, int bonus)
        : base(shortName, description, points)  //sends common values to the base class
    {
        //initializes the CheckListGoal specific fields
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;  //when you first create a checcklis goal, it starts with zero progress.
    }

    //First override - RecordEvent()
    //this method runs when the user reports progress on the goal.
      //What happens?
        //1. Increase progress ('_amountCompleted++')
        //2. If the target is reached, diplay a bonus message (does NOT actually add the bonus here, 'GoalManager' usually handles adding total points).

    public override void RecordEvent()
    {
        _amountCompleted++;
        
        if (_amountCompleted == _target)
        {
            Console.WriteLine($"Congratulations! You completed the goal and earned a bonus of {_bonus} points!");
        }
    }

    //Second override - IsComplete()
      //this returns 'rue' ONLY after the user completes the required number of repetiions.
      //E.G.
        //Target = 5, Completed = 3 -- 'false'
        //Target = 5, Completed = 5 -- 'true'
        //Target = 5, Completed = 7 -- still 'true'

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    //Third override - GetDetailsString()
    //this controls how the list is displayed on the screen
      //E.G.
        //[ ] Go to the gym (Weekly goal) -- Currently completed 1/3
        //[X] Go to the gym (Weekly goal) -- Currently completed 3/3

    public override string GetDetailsString()
    {
        string checkbox = IsComplete() ? "[X]" : "[ ]";
        return $"{checkbox} {_shortName} ({_description}) -- Currently completed {_amountCompleted}/{_target}";
    }

    //Fourth override - GetStringsRepresentation()
    //this controls how the goal is saved into a text file.
    public override string GetStringRepresentation()
    {
        //format for saving: ChecklistGoal:name, description, points, bonus, target, amountCompleted
        return $"CheckListGoal: {_shortName}, {_description}, {_points}, {_bonus}, {_target}, {_amountCompleted}";
    }
}

/*
Meaning:

type = ChecklistGoal

name = “Go to the gym”

description = “Weekly goal”

points per completion = 50

bonus for finishing = 200

target = 3

amount completed so far = 1

Loading the file later will reconstruct these values.
*/

/*
ChecklistGoal is a goal that:

must be repeated several times

tracks your progress

gives a bonus after finishing

appears differently on the screen

saves extra data to the file

And it all works using:

inheritance — getting shared fields and methods from Goal

polymorphism — overriding methods so they behave differently

extra fields — only ChecklistGoal uses target/bonus/completion count
*/