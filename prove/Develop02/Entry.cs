using System;
using System.Collections.Generic;
using System.IO;

public class Entry
{
    public string Prompt { get; set; }
    public string Comment { get; set; }
    public DateTime Time { get; set; }

    public Entry(string prompt, string comment, DateTime time = default(DateTime))
    {
        Prompt = prompt;
        Comment = comment;
        Time = time;
    }

    public Entry(string prompt, string comment)
    {
        Prompt = prompt;
        Comment = comment;
        Time = DateTime.Now;
    }

    public override string ToString()
    {
        return $"Prompt: {Prompt}, Comment: {Comment}, Time: {Time}";
    }
}