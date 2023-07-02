class ReceptionEvent : Event
{
    private string _email;

    public ReceptionEvent(string title, string description, DateTime date, string time, string email)
        : base(title, description, date, time, null)
    {
        _email = email;
    }

    public new string GetFullDetails()
    {
        return base.GetFullDetails() + $"\nType: Reception\nRSVP Email: {_email}";
    }
}
