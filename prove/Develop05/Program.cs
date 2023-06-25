using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public class Program
{
    private List<Activity> _goals;
    private int _score;
    private GoalFileManager _goalFileManager;

    public Program()
    {
        _goals = new List<Activity>();
        _score = 0;
        _goalFileManager = new GoalFileManager();
    }

    public void AddGoal(Activity goal)
    {
        _goals.Add(goal);
    }

    public void RecordEvent(Activity goal)
    {
        if (!goal.IsComplete)
        {
            goal.Complete();
            _score += goal.Value;
            Console.WriteLine("Event recorded successfully!");
        }
        else
        {
            Console.WriteLine("This goal has already been completed and cannot be recorded again.");
        }
    }

    public void DisplayGoals()
    {
        Console.WriteLine($"Current Score: {_score}");
        Console.WriteLine("---------------------");
        Console.WriteLine("Goals:");
        foreach (var goal in _goals)
        {
            Console.WriteLine($"{goal.GetStatus()}: Goal: {goal.Name}: Possible Points: {goal.Value}");
        }
    }

    public void SaveGoals(string fileName)
    {
        _goalFileManager.SaveGoalsToFile(_goals, _score, fileName);
    }

    public void LoadGoals(string fileName)
    {
        (_goals, _score) = _goalFileManager.LoadGoalsFromFile(fileName);
    }

    public void Run()
    {
        while (true)
        {
            Console.WriteLine("Eternal Quest Program");
            Console.WriteLine("---------------------");
            Console.WriteLine("1. Add Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Display Goals/Score");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Exit");
            Console.Write("Enter your choice: ");
            int _choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            switch (_choice)
            {
                case 1:
                    Console.WriteLine("Select goal type:");
                    Console.WriteLine("1. Simple Goal");
                    Console.WriteLine("2. Eternal Goal");
                    Console.WriteLine("3. Checklist Goal");
                    Console.WriteLine();
                    Console.Write("Enter goal type: ");
                    int _goalType = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter goal name: ");
                    string _name = Console.ReadLine();
                    Console.Write("Enter goal value: ");
                    int _value = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();


                    switch (_goalType)
                    {
                        case 1:
                            AddGoal(new SimpleGoal(_name, _value, false));
                            break;
                        case 2:
                            AddGoal(new EternalGoal(_name, _value, false));
                            break;
                        case 3:
                            Console.Write("Enter required times for the goal: ");
                            int _requiredTimes = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter bonus value for completing the goal: ");
                            int _bonus = Convert.ToInt32(Console.ReadLine());
                            bool _isComplete = false;
                            int _timesCompleted = 0; 
                            AddGoal(new ChecklistGoal(_name, _value, _isComplete, _timesCompleted, _requiredTimes, _bonus));
                            break;

                        default:
                            Console.WriteLine("Invalid goal type.");
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("Select the goal to record an event:");
                    for (int i = 0; i < _goals.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {_goals[i].Name}");
                    }
                    Console.Write("Enter goal number: ");
                    int _goalNumber = Convert.ToInt32(Console.ReadLine());

                    if (_goalNumber > 0 && _goalNumber <= _goals.Count)
                    {
                        RecordEvent(_goals[_goalNumber - 1]);
                    }
                    else
                    {
                        Console.WriteLine("Invalid goal number.");
                    }
                    Console.WriteLine();
                    break;
                case 3:
                    DisplayGoals();
                    Console.WriteLine();
                    break;
                case 4:
                    Console.Write("Enter file name to save goals: ");
                    string _saveFileName = Console.ReadLine();
                    SaveGoals(_saveFileName);
                    Console.WriteLine("Goals saved successfully!");
                    Console.WriteLine();
                    break;
                case 5:
                    Console.Write("Enter file name to load goals: ");
                    string _loadFileName = Console.ReadLine();
                    LoadGoals(_loadFileName);
                    Console.WriteLine("Goals loaded successfully!");
                    Console.WriteLine();
                    break;
                case 6:
                    Console.WriteLine("Exiting...");
                    Console.WriteLine();
                    return;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

            Console.WriteLine();
        }
    }

    public static void Main(string[] args)
    {
        Program _eternalQuest = new Program();
        _eternalQuest.Run();
    }
}