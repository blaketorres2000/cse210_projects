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

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }
        Entry other = (Entry)obj;
        return Prompt == other.Prompt && Comment == other.Comment && Time == other.Time;
    }

    public override int GetHashCode()
    {
        unchecked
        {
            int hash = 17;
            hash = hash * 23 + Prompt.GetHashCode();
            hash = hash * 23 + Comment.GetHashCode();
            hash = hash * 23 + Time.GetHashCode();
            return hash;
        }
    }
}