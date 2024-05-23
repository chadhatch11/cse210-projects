using System;
using System.Collections.Generic;

class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(string name, string description, int duration)
        : base(name, description, duration)
    {
    }

    public override void Run()
    {
        base.DisplayStartingMessage();
        base.ShowSpinner(10);
        Console.Clear();
        Console.WriteLine("Get ready...");
        base.ShowSpinner(5);
        Console.WriteLine();
        Console.WriteLine("List as many responses you can to the following prompt:");

        string prompt = GetRandomPrompt();
        Console.WriteLine($" {prompt} ");
        Console.WriteLine();
        Console.WriteLine($"You may begin in:");
        base.ShowCountDown(5);
        
        List<string> list = GetListFromUser();

        Console.WriteLine("Items listed:");
        foreach (string item in list)
        {
            Console.WriteLine($"- {item}");
            Console.WriteLine();
        }

        Console.WriteLine($"\nYou listed {list.Count} items");

        PromptToSaveList(list); 

        base.DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random rnd = new Random();
        int index = rnd.Next(_prompts.Count);
        return _prompts[index];
    }

    public List<string> GetListFromUser()
    {
        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(input))
            {
                items.Add(input);
            }
        }
        return items;
    }

    private void PromptToSaveList(List<string> list)
    {
        Console.Write("Do you want to save your list? (yes/no): ");
        string response = Console.ReadLine().Trim().ToLower();

        if (response == "yes")
        {
            SaveListToFile(list);
        }
    }

    private void SaveListToFile(List<string> list)
    {
        string fileName = $"ListingActivity.txt";
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            writer.WriteLine($"Listing Activity: ");
            writer.WriteLine($"Date: {DateTime.Now}");
            writer.WriteLine("Items listed");
            foreach (string item in list)
            {
                writer.WriteLine($"- {item}");
            }
        }

        Console.WriteLine($"Your list has been saved to {fileName}");
    }
}