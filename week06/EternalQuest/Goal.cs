using System;
using System.Runtime.CompilerServices;

//this is an abstract base class
//this stores shared attributes: short name. description, and points earned
//this provides abstract or virtual methods that the derived classes will complete

//'GetDetailString()'          virtual      What shows on thee main screen
//'GetStringRepresentation()'  abstract     Used to save goals to a file
//'RecordEvent()'              abstract     What happens whne user completes goal
//'IsComplete()'               abstract     Tell if the goal is done

public abstract class Goal;  //can't create a Goal object by itself, other classes inherit from it
{
    protected string _shortName;  // 'protected' so the derived classes can see them
    protected string _description;

    protected int _points;


    public Goal(string shortName, string description, int points)  // constructor - sets initial values for all goals
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    public virtual GetDetailString()  //this returns how the goal appears on the list
    {
        return $"{_shortName} ({_description})";
    }

    public abstract string GetStringRepresentation();  //used for saving goals to a file (must be overriden)
    //this is an abstract method, therefore there is no body. each child class saves itself in its own format
    /*SimpleGoal --
        SimpleGoal:Run|Exercise goal|100|False
    */
    /*EternalGoal --
        EternalGoal:Read Scriptures|Daily reading|50   
    */
    /*CheckListGoal --
        ChecklistGoal:Gym|Go 5 times|20|5|3|200  --  meaning: 1. Goal type, 2. Short name, 3. Description, 4. Points per event, 5. Target count, 6. Current count, 7. Bonus points.        
    */


    public abstract void RecordEvent();  //what happens when you complete the goal (must be overriden)
    //abstract - different goal types behave  (so each derived class writes its own version):
      /*//---SimpleGoal - marks completed, gives points once -- 
        public override void RecordEvent()
        {
            _isComplete = true;
            Console.WriteLine($"Congratulations! You earned {_points} points!");
        }*/

      /*//---EternalGoal - never completes, gives points each time --
        public override void RecordEvent()
        {
            _isComplete = true;
            Console.WriteLine($"Congratulations! You earned {_points} points!");
        }
      */

      /*//---ChecklistGoal - tracks repeated progress --
        'RecordEvent()' should 1. Increase the user's points, 2. Update the goal state, 3. Print  message.
         Go to the gym 5 times  
         20 points each time  
         200 bonus when done  
        */

      /*//---Program.cs
        public override void RecordEvent()
        {
            _currentCount++;

            if (_currentCount >= _targetCount)
            {
                Console.WriteLine($"You earned {_points + _bonus} points!");
            }
            else
            {
                Console.WriteLine($"You earned {_points} points!");
            }
        }
      */

    public abstract bool IsComplete();  //whether the goal is done (must be overriden)
    //abstract
        /*//---SimpleGoal - return true if marked complete --
        public override bool IsComplete()
        {
            return _isComplete;
        }
        --When it is completed once, it stays completed.--
        */

        /*//---EternalGoal - always false --
        public override bool IsComplete()
        {
            return false;
        }       
        --Never completes.--
        */

        /*//---ChecklistGoal - true only when max count reached --
        public override bool IsComplete()
        {
            return _currentCount >= _targetCount;
        }
        --Compleete when current progress reaches target. --
        */
}