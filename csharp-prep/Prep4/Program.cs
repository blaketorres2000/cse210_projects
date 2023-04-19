using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        
        int userInputParse = -1;
        while (userInputParse != 0)
        {
            Console.Write("Enter a number (0 to quit): ");
            
            string userInput = Console.ReadLine();
            userInputParse = int.Parse(userInput);
            
            // Only add the number to the list if it is not 0

            if (userInputParse != 0)
            {
                numbers.Add(userInputParse);
            }
        }

        // Get the sum

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        // Get the average

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // Get the max
        
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                // if this number is greater than the max, we have found the new max.
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");
    }
}