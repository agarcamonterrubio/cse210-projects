using System;
using System.Collections.Generic;
using System.Threading;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public override void Run()
    {
        Start();
        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];
        Console.WriteLine($"\n--- {prompt} ---");
        Console.WriteLine("You have a few seconds to think...");
        ShowSpinner(3);
        Console.WriteLine("\nStart listing items! Press Enter after each one:");

        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            if (Console.KeyAvailable)
            {
                string input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input)) items.Add(input);
            }
        }

        Console.WriteLine($"\nYou listed {items.Count} items.");
        End();
    }
}
