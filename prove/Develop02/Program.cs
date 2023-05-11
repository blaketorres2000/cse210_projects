using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        bool run = true;


        while(run == true)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Please choose a number from the following: ");
            Console.ResetColor();
            Console.WriteLine("1. Add Entry");
            Console.WriteLine("2. Load File");
            Console.WriteLine("3. Display Entries");
            Console.WriteLine("4. Delete Entries");
            Console.WriteLine("5. Save Entries");
            Console.WriteLine("6. Quit");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Enter number:  ");
            Console.ResetColor();
            string _userInput = Console.ReadLine();

            if (_userInput == "1") 
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Note: If you are adding entries before loading from a file,\nsave the new entries after each entry.\nOtherwise you will lose your new entries.");
                Console.ResetColor();
                Console.WriteLine();
                journal.PromptUserForEntry();
            }
            else if(_userInput == "2")
            {
                Console.WriteLine();
                journal.LoadEntriesFromCSV();
            }
            else if(_userInput == "3")
            {
                Console.WriteLine();
                journal.DisplayEntries();
            }
            else if(_userInput == "4")
            {
                Console.WriteLine();
                journal.DeleteEntries();
            }
            else if(_userInput == "5")
            {
                Console.WriteLine();
                journal.SaveEntriesToCSV();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Your entries have been saved to journal.csv.");
                Console.ResetColor();
            }
            else if(_userInput=="6")
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Remember to add an entry tomorrow.");
                Console.WriteLine("Goodbye!");
                Console.ResetColor();
                Console.WriteLine();
                run = false;
            }
            else
            {
                Console.WriteLine("Try again.");
            }
        }
    }
}