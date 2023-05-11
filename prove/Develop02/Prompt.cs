using System;
using System.Collections.Generic;
using System.IO;

public class Prompts
{
    public string [] _prompts=
    {
        "What did you eat for breakfast?",
        "What did you eat for lunch?",
        "What did you eat for dinner?",
        "Did you go anywhere?",
        "Who did you see?",
        "What did you like about your morning?",
        "What did you like about your afternoon?",
        "What did you like about your evening?",
        "Did you do your scripture study?",
        "Did you pray today?",
        "Did you exercise today?",
        "Did you complete any projects today?",
        "What goals have you made, are working on, or have completed?",
        "How was your overall mood today?",
        "What goals or actions could you improve upon?"
    };

    private Random _rand = new Random();
    public string GetRandomPrompt()
    {
        
        int index = _rand.Next(_prompts.Length);
        return _prompts[index];
    }
}
