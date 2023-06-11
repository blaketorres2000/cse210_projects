public class Log
{
    private static string _logFilePath = "log.txt";

    public static void AppendToLog(string _name, int _duration, int _itemCount = 0)
    {
        string _logEntry = $"{_duration} seconds of the {_name} completed";
        if (_itemCount > 0)
        {
            _logEntry += $" and {_itemCount} items listed";
        }
        _logEntry += $": {DateTime.Now}";

        File.AppendAllText(_logFilePath, _logEntry + Environment.NewLine);
    }

    public static void DisplayLog()
    {
        Console.WriteLine();
        string logContents = File.ReadAllText(_logFilePath);
        Console.WriteLine(logContents);
        Console.WriteLine();
    }

    public static void ClearLog()
    {
        Console.WriteLine();
        File.WriteAllText(_logFilePath, string.Empty);
        Console.WriteLine("Log cleared.");
        Console.WriteLine();
    }
}