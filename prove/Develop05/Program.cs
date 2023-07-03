using System;
using System.Collections.Generic;
using System.IO;

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
            Console.WriteLine($"Current Score: {_score}");

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
            goal.Display();
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
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Select goal type:");
                    Console.WriteLine("1. Simple Goal");
                    Console.WriteLine("2. Eternal Goal");
                    Console.WriteLine("3. Checklist Goal");
                    Console.WriteLine();
                    Console.Write("Enter goal type: ");
                    int goalType = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter goal name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter goal value: ");
                    int value = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    switch (goalType)
                    {
                        case 1:
                            AddGoal(new SimpleGoal(name, value, false));
                            break;
                        case 2:
                            AddGoal(new EternalGoal(name, value, false));
                            break;
                        case 3:
                            Console.Write("Enter required times for the goal: ");
                            int requiredTimes = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter bonus value for completing the goal: ");
                            int bonus = Convert.ToInt32(Console.ReadLine());
                            bool isComplete = false;
                            int timesCompleted = 0;
                            AddGoal(new ChecklistGoal(name, value, isComplete, timesCompleted, requiredTimes, bonus));
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
                    int goalNumber = Convert.ToInt32(Console.ReadLine());

                    if (goalNumber > 0 && goalNumber <= _goals.Count)
                    {
                        RecordEvent(_goals[goalNumber - 1]);
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
                    string saveFileName = Console.ReadLine();
                    SaveGoals(saveFileName);
                    Console.WriteLine("Goals saved successfully!");
                    Console.WriteLine();
                    break;
                case 5:
                    Console.Write("Enter file name to load goals: ");
                    string loadFileName = Console.ReadLine();
                    LoadGoals(loadFileName);
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
        Program eternalQuest = new Program();
        eternalQuest.Run();
    }
}

