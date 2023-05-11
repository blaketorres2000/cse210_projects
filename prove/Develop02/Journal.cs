using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private Prompts _prompts = new Prompts();
    private List<Entry> _entries = new List<Entry>();

    public void PromptUserForEntry()
    {
        string prompt = _prompts.GetRandomPrompt();
        Console.Write(prompt + " ");
        string comment = Console.ReadLine();

        Entry entry = new Entry(prompt, comment);
        _entries.Add(entry);
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Entry saved: " + entry.ToString());
        Console.ResetColor();
    }

    public void LoadEntriesFromCSV()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Please enter the name of the file to be loaded (include the file path): ");
        Console.ResetColor();
        string _fileName = Console.ReadLine();

        if (!File.Exists(_fileName))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("No such file found.");
            Console.ResetColor();
            return;
        }
        else
        {
            _entries.Clear();

            using (StreamReader _reader = new StreamReader(_fileName))
            {
                string _line;
                bool _isFirstLine = true;

                while ((_line = _reader.ReadLine()) != null)
                {
                    if (_isFirstLine)
                    {
                        _isFirstLine = false;
                        continue;
                    }

                    string[] _parts = _line.Split(',');

                    if (_parts.Length >= 3)
                    {
                        string _prompt = _parts[0].Trim('"');
                        string _comment = _parts[1].Trim('"');
                        DateTime _time;
                        if (DateTime.TryParse(_parts[2], out _time))
                        {
                            Entry _entry = new Entry(_prompt, _comment, _time);
                            _entries.Add(_entry);
                        }
                    }
                }
            }
        }

        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Loaded " + _entries.Count + " entries.");
        Console.ResetColor();
        Console.WriteLine();

        File.Delete(_fileName);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("REMINDER:");
        Console.WriteLine("The entries from your file have now been added to the list\nand your original file has been deleted.");
        Console.WriteLine("So be sure to save your entries once you are done adding\nand/or deleting, so you do not lose any of your past entries.");
        Console.ResetColor();
    }

    public void DisplayEntries()
    {
        if (_entries.Count == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("No entries to display.");
            Console.ResetColor();
            return;
        }

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Entries:");
        Console.ResetColor();

        for (int i = 0; i < _entries.Count; i++)
        {
            Entry _entry = _entries[i];
            Console.WriteLine($"{i + 1}. {_entry.ToString()}");
        }
    }

    public void DeleteEntries()
    {
        if (_entries.Count == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("No entries to display.");
            Console.ResetColor();
            return;
        }

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Entries:");
        Console.ResetColor();

        for (int i = 0; i < _entries.Count; i++)
        {
            Entry _entry = _entries[i];
            Console.WriteLine($"{i + 1}. {_entry.ToString()}");
        }

        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Enter the number of the entry you would like to delete: ");
        Console.ResetColor();

        if (int.TryParse(Console.ReadLine(), out int index))
        {
            if (index >= 1 && index <= _entries.Count)
            {
                Entry _deletedEntry = _entries[index - 1];
                _entries.RemoveAt(index - 1);
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Entry deleted: " + _deletedEntry.ToString());
                Console.ResetColor();
            }
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid entry. Please enter a valid entry.");
            Console.ResetColor();
        }
    }

    public void SaveEntriesToCSV()
    {
        string _csvFilePath = "journal.csv";
        
        bool _fileExists = File.Exists(_csvFilePath);
        
        using (StreamWriter _writer = new StreamWriter(_csvFilePath, true))
        {
            if (!_fileExists)
            {
                _writer.WriteLine($"Prompt,Comment,Time");
            }
            foreach (Entry _entry in _entries)
            {
                _writer.WriteLine($"\"{_entry.Prompt}\",\"{_entry.Comment}\",{_entry.Time}");
            }
        }
    }
}
