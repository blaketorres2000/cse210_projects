using System.Diagnostics;

class ListingActivity : Activity
{
    public override string GetName()
    {
        return _name;
    }

    private string[] _prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private Random _random = new Random();


    public ListingActivity() : base("Listing Activity", "This activity will help you " +
    "reflect on the good things in your life by having you list as many things as you " +
    "can in a certain area.")
    {
    }

    public override void PerformActivity(int _duration, Log log)
    {
        DisplayStartMessage(_duration);
        Random _random = new Random();
        int _promptIndex = _random.Next(_prompts.Length);

        string _prompt = _prompts[_promptIndex];
        Console.WriteLine("Your prompt is: ");
        Console.WriteLine(_prompt);
        Console.WriteLine("You have several seconds to think about it...");
        CountDown();

        Stopwatch _stopwatch = Stopwatch.StartNew();

        int _itemCount = 0;
        while (_stopwatch.Elapsed.Seconds < _duration)
        {
            Console.WriteLine("Enter an item: ");
            string _item = Console.ReadLine();
            _itemCount++;
        }

        _stopwatch.Stop();

        Console.WriteLine($"You have listed {_itemCount} items.");
        DisplayEndMessage(_duration);

        // Write activity details to the log file
        Log.AppendToLog(_name, _duration, _itemCount);
    }
}
