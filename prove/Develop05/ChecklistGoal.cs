public class ChecklistGoal : Activity
{
    private int _requiredTimes;
    private int _timesCompleted;
    private int _bonus;

    public ChecklistGoal(string name, int value, bool isComplete, int timesCompleted, int requiredTimes, int bonus)
        : base(name, value)
    {
        IsComplete = isComplete;
        _timesCompleted = timesCompleted;
        _requiredTimes = requiredTimes;
        _bonus = bonus;
    }

    public int RequiredTimes
    {
        get { return _requiredTimes; }
        set { _requiredTimes = value; }
    }

    public int TimesCompleted
    {
        get { return _timesCompleted; }
        set { _timesCompleted = value; }
    }

    public int Bonus
    {
        get { return _bonus; }
        set { _bonus = value; }
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

    public override void Display()
    {
        if (TimesCompleted == RequiredTimes)
        {
            Console.WriteLine("[X]: Goal: {Name}: Possible Points: {Value}");
        }
        else
        {
            Console.WriteLine($"[ ]: Completed {TimesCompleted}/{RequiredTimes} times: Goal: {Name}: Possible Points: {Value}");
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
