using System;
using System.Threading;

class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {
    }

    public override void Run()
    {
        base.DisplayStartingMessage();
        Console.Clear();
        Console.WriteLine("Get Ready...");  // Line 33
        base.ShowSpinner(5);   
        Console.WriteLine();

        int cycles = _duration / 10;
        for (int i = 0; i < cycles; i++)
        {
            Console.WriteLine("Breathe in...");
            base.ShowCountDown(5);
            Console.WriteLine("Now breathe out...");
            base.ShowCountDown(5);
            Console.WriteLine();
        }
        base.DisplayEndingMessage();
    }
}
