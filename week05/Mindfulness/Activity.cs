using System;
using System.Threading;

public abstract class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public void Start()
    {
        Console.Clear();
        Console.WriteLine($"--- {_name} ---\n");
        Console.WriteLine($"{_description}\n");
        Console.Write("Enter duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
    }

    public void End()
    {
        Console.WriteLine("\nWell done!");
        ShowSpinner(2);
        Console.WriteLine($"\nYou have completed the {_name} for {_duration} seconds.");
        ShowSpinner(3);
    }

    protected void ShowSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[i % 4]);
            Thread.Sleep(250);
            Console.Write("\b");
            i++;
        }
    }

    protected void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i} ");
            Thread.Sleep(1000);
            Console.Write("\b\b");
        }
        Console.WriteLine();
    }

    public abstract void Run();
}
