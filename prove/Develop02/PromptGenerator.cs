using System;
public class PromptGenerator
{
    List<string> prompts = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?" 
    };
    public Random random = new Random();
    
    public string _randomPrompt;
    public string Display()
    {
        _randomPrompt = prompts[random.Next(0, prompts.Count)];
        Console.WriteLine($"{_randomPrompt}");
        return _randomPrompt;
    }
     
}
