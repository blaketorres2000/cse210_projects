public class SimpleGoal : Activity
{
    public SimpleGoal(string name, int value, bool isComplete) : base(name, value) { }

    public override void Complete()
    {
        IsComplete = true;
    }

    public override string GetStatus()
    {
        return IsComplete ? "[X]" : "[ ]";
    }
}