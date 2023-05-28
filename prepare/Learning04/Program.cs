using System;

class Program
{
    static void Main(string[] args)
    {
        Homework _homework = new Homework("Blake Torres", "Quadratic Equation");
        MathHomework _mathHomework = new MathHomework("Blake Torres", "Quadratic Equations", "12.2", "1-99");
        Console.WriteLine(_mathHomework.GetSummary());
        Console.WriteLine(_mathHomework.GetHomeworkList());

        WritingHomework _writingHomework = new WritingHomework("Blake Torres", "European History Sucks", "They caused WWII");
        Console.WriteLine(_writingHomework.GetSummary());
        Console.WriteLine(_writingHomework.GetWritingInfo());
    }
}