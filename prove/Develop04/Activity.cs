using System;
using System.Threading;

abstract class Activity
{
    protected string _name;
    protected string _description;

    public abstract string GetName();

    public Activity(string _name, string _description)
    {
        this._name = _name;
        this._description = _description;
    }

    public void DisplayStartMessage(int _duration)
    {
        Console.Clear();
        Spinner();
        Console.WriteLine($"{_name} - {_description}");
        Console.WriteLine($"Duration: {_duration} seconds");
    }

    public void DisplayEndMessage(int _duration)
    {
        Console.WriteLine("Good job!");
        Spinner();
        Console.WriteLine($"You have completed {_name} for {_duration} seconds.");
        Spinner();
        Console.Clear();
    }

    public abstract void PerformActivity(int _duration, Log _log);

    public void Spinner()
    {
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 100; j++)
            {
                Console.Write("_");
                Thread.Sleep(10);
            }
            Console.Write("\r" + new string(' ', Console.WindowWidth - 1) + "\r");
        }
        Console.WriteLine();
    }

    public void Spinner2()
    {
        int initialCursorLeft = Console.CursorLeft;

        for (int i = 0; i < 12; i++)
        {
            Console.SetCursorPosition(initialCursorLeft, Console.CursorTop);
            Console.Write("- ");
            Thread.Sleep(100);
            Console.SetCursorPosition(Console.CursorLeft - 2, Console.CursorTop);
            Console.Write("  ");
            Console.SetCursorPosition(initialCursorLeft, Console.CursorTop);
            Console.Write("| ");
            Thread.Sleep(100);
            Console.SetCursorPosition(Console.CursorLeft - 2, Console.CursorTop);
            Console.Write("  ");
            Console.SetCursorPosition(initialCursorLeft, Console.CursorTop);
            Console.Write("- ");
            Thread.Sleep(100);
            Console.SetCursorPosition(Console.CursorLeft - 2, Console.CursorTop);
            Console.Write("  ");
            Console.SetCursorPosition(initialCursorLeft, Console.CursorTop);
            Console.Write("| ");
            Thread.Sleep(100);
            Console.SetCursorPosition(Console.CursorLeft - 2, Console.CursorTop);
            Console.Write("  ");
        }
        Console.WriteLine();
    }

    private int _initialLineCursor;

    protected void CountDown()
    {
        Console.WriteLine($"Prepare to begin in...");

        int initialCursorLeft = Console.CursorLeft;

        for (int i = 10; i >= 1; i--)
        {
            Console.SetCursorPosition(initialCursorLeft, Console.CursorTop);
            Console.Write(i + " ");
            Thread.Sleep(1000);
            Console.SetCursorPosition(Console.CursorLeft - 2, Console.CursorTop);
            Console.Write("  ");
        }
        Console.WriteLine();
    }

        protected void CountDown2()
    {
        int initialCursorLeft = Console.CursorLeft;

        for (int i = 5; i >= 1; i--)
        {
            Console.SetCursorPosition(initialCursorLeft, Console.CursorTop);
            Console.Write(i + " ");
            Thread.Sleep(1000);
            Console.SetCursorPosition(Console.CursorLeft - 2, Console.CursorTop);
            Console.Write("  ");
        }
        Console.WriteLine();
    }
}

