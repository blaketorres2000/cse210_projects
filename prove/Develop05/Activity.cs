public abstract class Activity
{
    public string Name { get; set; }
    public int Value { get; set; }
    public bool IsComplete { get; set; }

    protected Activity(string name, int value)
    {
        Name = name;
        Value = value;
        IsComplete = false;
    }

    public abstract void Complete();

    public abstract string GetStatus();
}
