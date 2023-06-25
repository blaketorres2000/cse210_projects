public class GoalFileManager
{
    public void SaveGoalsToFile(List<Activity> goals, int score, string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            writer.WriteLine(score); 
            foreach (var goal in goals)
            {
                if (goal is ChecklistGoal checklistGoal)
                {
                    writer.WriteLine($"{goal.GetType().Name}|{goal.Name}|{goal.Value}|{goal.IsComplete}|{checklistGoal.TimesCompleted}|{checklistGoal.RequiredTimes}|{checklistGoal.Bonus}");
                }
                else
                {
                writer.WriteLine($"{goal.GetType().Name}|{goal.Name}|{goal.Value}|{goal.IsComplete}|0|0|0");
                }
            }
        }
    }

    public (List<Activity> goals, int score) LoadGoalsFromFile(string fileName)
    {
        List<Activity> goals = new List<Activity>();
        int score = 0; 

        using (StreamReader reader = new StreamReader(fileName))
        {
            if (!reader.EndOfStream)
            {
                string scoreLine = reader.ReadLine();
                score = int.Parse(scoreLine);
            }
            while (!reader.EndOfStream)
            {
                string[] goalData = reader.ReadLine().Split('|');

                string goalType = goalData[0];
                string name = goalData[1];
                int value = int.Parse(goalData[2]);
                bool isComplete = bool.Parse(goalData[3]);
                int timesCompleted = int.Parse(goalData[4]);
                int requiredTimes = int.Parse(goalData[5]);
                int bonus = int.Parse(goalData[6]);

                Activity goal;

                switch (goalType)
                {
                    case nameof(SimpleGoal):
                        goal = new SimpleGoal(name, value, isComplete);
                        break;
                    case nameof(EternalGoal):
                        goal = new EternalGoal(name, value, isComplete);
                        break;
                    case nameof(ChecklistGoal):
                        goal = new ChecklistGoal(name, value, isComplete, timesCompleted, requiredTimes, bonus);
                        break;
                    default:
                        Console.WriteLine("Invalid goal type in the file.");
                        continue;
                }

                goal.IsComplete = isComplete;
                goals.Add(goal);
            }
        }

        return (goals, score);
    }
}
