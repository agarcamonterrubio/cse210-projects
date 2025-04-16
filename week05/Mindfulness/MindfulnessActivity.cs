using System;
using System.Threading;

public class MindfulnessActivity
{
    protected string _activityName;
    protected string _description;
    protected int _duration;

    public MindfulnessActivity(string activityName, string description)
    {
        _activityName = activityName;
        _description = description;
    }

    public void StartActivity()
    {
        Console.WriteLine($"\nStarting {_activityName}");
        Console.WriteLine(_description);
        Console.Write("Enter the duration for this activity in seconds: ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready to begin...");
        Thread.Sleep(2000);  // Pause before starting
        PerformActivity();
    }

    public virtual void PerformActivity()
    {
        // Método a ser implementado en las clases derivadas
    }

    public void EndActivity()
    {
        Console.WriteLine($"\nGood job! You completed the {_activityName}.");
        Console.WriteLine($"You spent {_duration} seconds on this activity.");
        Thread.Sleep(2000);  // Pause before finishing
    }

    public void ShowPauseAnimation()
    {
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"....{new string('.', i)}", 0, 5);
            Thread.Sleep(1000);
        }
    }
}
