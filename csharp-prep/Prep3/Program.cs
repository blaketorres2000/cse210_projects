using System;

class Program
{
    static void Main(string[] args)
    {
        
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;

        
        while (guess != magicNumber)
        {
            Console.Write("Guess a number? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Guess higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Guess lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

        }                    
    }
}