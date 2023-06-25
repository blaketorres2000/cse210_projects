public class ChecklistGoal : Activity
{
    public int RequiredTimes { get; set; }
    public int TimesCompleted { get; set; }
    public int Bonus { get; set; }

    public ChecklistGoal(string name, int value, bool isComplete, int timesCompleted, int requiredTimes, int bonus) : base(name, value)
    {
        IsComplete = isComplete;
        TimesCompleted = timesCompleted;
        RequiredTimes = requiredTimes;
        Bonus = bonus;
    }

    public override void Complete()
    {
        TimesCompleted++;

        if (TimesCompleted == RequiredTimes)
        {
            Value += Bonus;
            IsComplete = true;
        }
    }

    public override string GetStatus()
    {
        if (TimesCompleted == RequiredTimes)
        {
            return "[X]";
        }
        else
        {
            return $"[ ]: Completed {TimesCompleted}/{RequiredTimes} times";
        }
    }
}
