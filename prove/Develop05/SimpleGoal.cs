public class SimpleGoal : Activity
{
    public SimpleGoal(string name, int value, bool isComplete) : base(name, value)
    {
        IsComplete = isComplete;
    }

    public override void Complete()
    {
        IsComplete = true;
    }

    public override void Display()
    {
        Console.WriteLine($"{GetStatus()}: Goal: {Name}: Possible Points: {Value}");
    }

    public override string GetStatus()
    {
        return IsComplete ? "[X]" : "[ ]";
    }
}

