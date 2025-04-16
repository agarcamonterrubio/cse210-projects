using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public override void Run()
    {
        Start();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in...");
            Countdown(4);
            Console.Write("Breathe out...");
            Countdown(6);
        }
        End();
    }
}
