using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading;

class ReflectingActivity : Activity
{
    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    private List<string> _prompts = new List<string>
    {
        " Think of a time when you stood up for someone else.",
        " Think of a time when you did something really difficult.",
        " Think of a time when you helped someone in need.",
        " Think of a time when you did something truly selfless."
    };
    private Random _random;

    public ReflectingActivity(string name, string description, int duration)
        : base(name, description, duration)
    {
        _random = new Random();
    }

    public override void Run()
    {
        base.DisplayStartingMessage();
        Console.Clear();
        Console.WriteLine("Get ready...");
        base.ShowSpinner(5);
        Console.WriteLine();

        string prompt = GetRandomPrompt();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($" {prompt} ");
        Console.WriteLine("When you have something in mind, press enter.");
        Console.ReadLine();
        Console.WriteLine("Now ponder each of the following questions as they relate to this experience.");
        Console.WriteLine("You may being in:");
        base.ShowCountDown(5);

        Console.Clear();
        int questionCount = Math.Min(_questions.Count, _duration / 10);
        for (int i = 0; i < questionCount; i++)
        {
            string question = GetRandomQuestion();
            Console.Write($"> {question} ");
            base.ShowSpinner(10);
            Console.WriteLine();
        }

        base.DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }

    public string GetRandomQuestion()
    {
        int index = _random.Next(_questions.Count);
        return _questions[index];
    }
}