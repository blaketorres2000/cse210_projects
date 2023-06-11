using System.Diagnostics;

class BreathingActivity : Activity
{
    public override string GetName()
    {
        return _name;
    }

    public BreathingActivity() : base("Breathing Activity", "This " +
        "activity will help you relax by walking you through breathing in " +
        "and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public override void PerformActivity(int _duration, Log log)
    {   
        DisplayStartMessage(_duration);
        CountDown();

        Stopwatch _stopwatch = Stopwatch.StartNew();

        while (_stopwatch.Elapsed.TotalSeconds < _duration)
        {
            Console.WriteLine("Breathe in...");
            CountDown2();
            Console.WriteLine("Breathe out...");
            CountDown2();
        }

        _stopwatch.Stop();

        DisplayEndMessage(_duration);

        Log.AppendToLog(_name, _duration);
    }
}
