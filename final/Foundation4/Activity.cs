abstract class Activity
{
    private DateTime date;
    protected int minutes;

    public Activity(DateTime date, int minutes)
    {
        this.date = date;
        this.minutes = minutes;
    }

    protected abstract double CalculateDistance();
    protected abstract double CalculateSpeed();
    protected abstract double CalculatePace();

    public virtual string GetSummary()
    {
        double distance = CalculateDistance();
        double speed = CalculateSpeed();
        double pace = CalculatePace();

        string summary = $"{date.ToString("dd MMM yyyy")} {GetType().Name} ({minutes} min): " +
            $"Distance: {distance} km, Speed: {speed} kph, Pace: {pace} min per km";

        return summary;
    }
}