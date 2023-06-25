public class EternalGoal : Activity
{
    public EternalGoal(string name, int value, bool isComplete) : base(name, value) { }

    public override void Complete()
    {
        // No action required for EternalGoal
    }

    public override string GetStatus()
    {
        return "[ ]";
    }
}