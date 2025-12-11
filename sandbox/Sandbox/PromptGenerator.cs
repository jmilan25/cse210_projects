using System;
using System.Collections.Generic;
public class PromptGenerator
{
    Random _random = new Random();
    List<string> _prompts = new List<string>();

    public string GetRandomPrompt()
    {

        _prompts.Add("What was the best part of my day? ");  
        _prompts.Add("How did I see the hand of the Lord in my life today? ");  
        _prompts.Add("What was the strongest emotion I felt today? ");
        _prompts.Add("If I had one thing I could do over today, what would it be? ");
        // _prompts.Add("");  

        int index = _random.Next(_prompts.Count);
        string randomPrompt = _prompts[index];
        

        return randomPrompt;
    }
}