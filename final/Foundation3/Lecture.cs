class LectureEvent : Event
{
    private string _speaker;
    private int _capacity;

    public LectureEvent(string title, string description, DateTime date, string time, string speaker, int capacity)
        : base(title, description, date, time, null)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public new string GetFullDetails()
    {
        return base.GetFullDetails() + $"\nType: Lecture\nSpeaker: {_speaker}\nCapacity: {_capacity}";
    }
}