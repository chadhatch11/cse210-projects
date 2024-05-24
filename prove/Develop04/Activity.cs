using System;
using System.Threading;

class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} activity.");
        Console.WriteLine($"\n{_description}");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Well done! ");
        Console.WriteLine();
        ShowSpinner(5);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity.");
        ShowSpinner(5);
    }

    public void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("/");
            Thread.Sleep(200);
            Console.Write("\b");

            Console.Write("-");
            Thread.Sleep(200);
            Console.Write("\b");

            Console.Write("\\");
            Thread.Sleep(200);
            Console.Write("\b");

            Console.Write("|");
            Thread.Sleep(200);
            Console.Write("\b");
        }
        Console.Write("\b\b");
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i}");
            Thread.Sleep(500);
            Console.Write("\b\b");
        }
    }

    public virtual void Run()
    {
      Console.WriteLine(" ");  
    }
}