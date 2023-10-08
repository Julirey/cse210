using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public string GetPrompt()
    {
        List<string> Prompts = new List<string>();
        
        Prompts.Add("Who was the most interesting person I interacted with today?");
        Prompts.Add("What was the best part of my day?");
        Prompts.Add("How did I see the hand of the Lord in my life today?");
        Prompts.Add("What was the strongest emotion I felt today?");
        Prompts.Add("If I had one thing I could do over today, what would it be?");
        Prompts.Add("What was best food that I ate today?");
        Prompts.Add("What was the thing you did the most today");
        Prompts.Add("What was the thing you did the least today");
        
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(0, Prompts.Count);

        string prompt = Prompts[number];
        return prompt;
    }
}
