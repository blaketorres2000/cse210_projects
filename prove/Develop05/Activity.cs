public abstract class Activity
{
    private string _name;
    private int _value;
    private bool _isComplete;

    protected Activity(string name, int value)
    {
        _name = name;
        _value = value;
        _isComplete = false;
    }

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public int Value
    {
        get { return _value; }
        set { _value = value; }
    }

    public bool IsComplete
    {
        get { return _isComplete; }
        set { _isComplete = value; }
    }

    public abstract void Complete();

    public abstract string GetStatus();

    public abstract void Display();
}
