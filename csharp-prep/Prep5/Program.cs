using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }
        static string PromptUserName()
        {
            Console.Write("What is your name? ");
            string Name = Console.ReadLine();
            return Name;
        }
        static int PromptUserNumber()
        {
            Console.Write("What is your favorite number? ");
            string number = Console.ReadLine();
            int num = int.Parse(number);
            return num;
        }
        static int SquareNumber(int numberInput)
        {
            int SquareRoot = (int)Math.Sqrt(numberInput);
            return SquareRoot;
        }
        DisplayWelcome();
        string Namer = PromptUserName();
        int number = PromptUserNumber();
        Console.WriteLine($"{Namer}, the square root of your number is {SquareNumber(number)}");
    }
}