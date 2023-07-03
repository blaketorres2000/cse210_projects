public class EternalGoal : Activity
{
    public EternalGoal(string name, int value, bool isComplete) : base(name, value)
    {
        IsComplete = isComplete;
    }

    public override void Complete()
    {
        // No action required for EternalGoal
    }

    public override void Display()
    {
        Console.WriteLine($"{GetStatus()}: Goal: {Name}: Possible Points: {Value}");
    }

    public override string GetStatus()
    {
        return "[ ]";
    }
}
