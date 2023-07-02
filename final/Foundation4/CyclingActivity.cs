class CyclingActivity : Activity
{
    private double speed;

    public CyclingActivity(DateTime date, int minutes, double speed) : base(date, minutes)
    {
        this.speed = speed;
    }

    protected override double CalculateDistance()
    {
        return speed * (base.minutes / 60.0);
    }

    protected override double CalculateSpeed()
    {
        return speed;
    }

    protected override double CalculatePace()
    {
        return (60.0 / speed);
    }
}
