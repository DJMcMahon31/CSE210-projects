using System;

/*This class involves:
    managing a list of polymorphic objects
    saving/loading different goal types
    tracking total points
    handling the menu
    creating the correct type of goal
    awarding points and bonuses correctly
*/

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();  //keeps track of created goals
    private int _score;  //tracks the user's total points

    /*
    Display a menu
        -Create goals
        -List goals
        -Record events
        -Save goals
        -Load goals
        -Quit 
    Save goals to a file
    Load goals from a file
    Award points correctly
    */

    public void Start()
    {
        int choice = 0;

        while (choice != 6)
        {
            Console.WriteLine($"\nYou have {_score} points.\n");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");

            Console.Write("Select a choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1: CreateGoal(); break;
                case 2: ListGoalDetails(); break;
                case 3: SaveGoals(); break;
                case 4: LoadGoals(); break;
                case 5: RecordEvent(); break;
            }
        }
    }

    //Create Goal

    private void CreateGoal()
    {
        Console.WriteLine("\nThe types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type would you like to create? ");

        int type = int.Parse(Console.ReadLine());

        Console.Write("Enter name: ");
        string name = Console.ReadLine();

        Console.Write("Enter description: ");
        string description = Console.ReadLine();

        Console.Write("Enter points: ");
        int points = int.Parse(Console.ReadLine());

        
        if (type == 1)
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }
        else if (type == 2)
        {
            _goals.Add(new EternalGoal(name, description, points));
        }
        else if (type == 3)
        {
            Console.Write("Enter target: ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("Enter bonus: ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
        }
    }

    //List Goals
    private void ListGoalDetails()
        {
            Console.WriteLine("\nYour goals:");

            int i = 1;
            foreach (Goal g in _goals)
            {
                Console.WriteLine($"{i}. {g.GetDetailsString()}");
                i++;
            }
        }

    //Record an Event
    private void RecordEvent()
    {
        Console.WriteLine("\nWhich goal did you accomplish?");
        ListGoalNames();

        int choice = int.Parse(Console.ReadLine());
        Goal g = _goals[choice - 1];

        // Add points
        _score += g.GetPoints();

        // Extra bonus for checklist goals when completed
        if (g is ChecklistGoal checklist)
        {
            int before = checklist.GetAmountCompleted();

            checklist.RecordEvent();

            if (before != checklist.GetAmountCompleted() &&
                checklist.IsComplete())
            {
                _score += checklist.GetBonus();
            }
         }
        else
        {
            g.RecordEvent();
        }

    }

    //Helper for listing names only
    private void ListGoalNames()
    {
        int i = 1;
        foreach (Goal g in _goals)
        {
            Console.WriteLine($"{i}. {g.GetShortName()}");
            i++;
        }
    }

    //Save Goals to File
    private void SaveGoals()
    {
         Console.Write("Enter the filename: ");
        string filename = Console.ReadLine();

        using (StreamWriter output = new StreamWriter(filename))
        {
            output.WriteLine(_score);

            foreach (Goal g in _goals)
            {
                output.WriteLine(g.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals saved!");
    }

    //Load Goals from File
    private void LoadGoals()
    {
        Console.Write("Enter filename: ");
        string filename = Console.ReadLine();

        string[] lines = File.ReadAllLines(filename);

        _score = int.Parse(lines[0]);
        _goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            Goal loadedGoal = ParseGoalFromString(lines[i]);
            _goals.Add(loadedGoal);
        }

        Console.WriteLine("Goals loaded!");
    }
    
    //Load a single line into th right goal type
    private Goal ParseGoalFromString(string line)
    {
string[] parts = line.Split(':');
        string type = parts[0];
        string[] data = parts[1].Split(',');

        if (type == "SimpleGoal")
        {
            return new SimpleGoal(data[0], data[1], int.Parse(data[2]))
            {
                // set completion state
            };
        }
        else if (type == "EternalGoal")
        {
            return new EternalGoal(data[0], data[1], int.Parse(data[2]));
        }
        else // ChecklistGoal
        {
            return new ChecklistGoal(
                data[0], data[1],
                int.Parse(data[2]),  // points
                int.Parse(data[4]),  // target
                int.Parse(data[3])   // bonus
            )
            {
                AmountCompleted = int.Parse(data[5])
            };
        }
    }



}
