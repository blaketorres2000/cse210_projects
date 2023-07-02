class SwimmingActivity : Activity
{
    private int laps;

    public SwimmingActivity(DateTime date, int minutes, int laps) : base(date, minutes)
    {
        this.laps = laps;
    }

    protected override double CalculateDistance()
    {
        return laps * 50 / 1000.0;
    }

    protected override double CalculateSpeed()
    {
        return (CalculateDistance() / (base.minutes / 60.0));
    }

    protected override double CalculatePace()
    {
        return (base.minutes / CalculateDistance());
    }
}