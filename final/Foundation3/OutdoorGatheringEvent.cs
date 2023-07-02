class OutdoorGatheringEvent : Event
{
    private string _weather;

    public OutdoorGatheringEvent(string title, string description, DateTime date, string time, string weather)
        : base(title, description, date, time, null)
    {
        _weather = weather;
    }

    public new string GetFullDetails()
    {
        return base.GetFullDetails() + $"\nType: Outdoor Gathering\nWeather: {_weather}";
    }
}