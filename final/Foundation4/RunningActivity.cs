class RunningActivity : Activity
{
    private double distance;

    public RunningActivity(DateTime date, int minutes, double distance) : base(date, minutes)
    {
        this.distance = distance;
    }

    protected override double CalculateDistance()
    {
        return distance;
    }

    protected override double CalculateSpeed()
    {
        return distance / (base.minutes / 60.0);
    }

    protected override double CalculatePace()
    {
        return (base.minutes / distance);
    }
}