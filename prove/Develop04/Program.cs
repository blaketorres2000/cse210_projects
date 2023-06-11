using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("Welcome to the Mindfulness App!");

        Log _log = new Log();

        while (true)
        {
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. View Log");
            Console.WriteLine("5. Clear Log");
            Console.WriteLine("6. Quit");

            Console.Write("Enter the number of the Mindfulness activity you would like to participate in: ");
            string _choice = Console.ReadLine();
            Console.WriteLine();

            Activity _activity = null;

            switch (_choice)
            {
                case "1":
                    _activity = new BreathingActivity();
                    break;
                case "2":
                    _activity = new ReflectionActivity();
                    break;
                case "3":
                    _activity = new ListingActivity();
                    break;
                case "4":
                    Log.DisplayLog();
                    continue;
                case "5":
                    Log.ClearLog();
                    continue;
                case "6":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    continue;
            }

            if (_activity == null)
            {
                Console.WriteLine("Invalid choice. Please try again.");
                continue;
            }

            Console.Write("Enter the amount of time you want the activity to last in seconds: ");
            int _duration = Convert.ToInt32(Console.ReadLine());

            _activity.PerformActivity(_duration, _log);
            Console.WriteLine();
        }
    }
}