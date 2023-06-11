using System.Diagnostics;

class ReflectionActivity : Activity
{
    public override string GetName() 
    {
        return _name;
    }
    private string[] _prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] _questions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    private Random _random = new Random();

    public ReflectionActivity() : base("Reflection Activity", "This activity will help you " +
    "reflect on times in your life when you have shown strength and resilience. This will " +
    "help you recognize the power you have and how you can use it in other aspects of your life.")
    {
    }

    public override void PerformActivity(int _duration, Log log)
    {
        DisplayStartMessage(_duration);
        Random _random = new Random();
        int _promptIndex = _random.Next(_prompts.Length);

        Console.WriteLine("This is your prompt: ");
        string _prompt = _prompts[_promptIndex];
        Console.WriteLine(_prompt);
        CountDown();

        Stopwatch _stopwatch = Stopwatch.StartNew();

        while (_stopwatch.Elapsed.TotalSeconds < _duration)
        {
            int _questionIndex = _random.Next(_questions.Length);
            string _question = _questions[_questionIndex];
            Console.WriteLine(_question);
            Spinner2();
        }

        _stopwatch.Stop();

        DisplayEndMessage(_duration);

        Log.AppendToLog(_name, _duration);
    }
}