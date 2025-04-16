using System;
using System.Collections.Generic;

class Program
{
    static List<Goal> goals = new List<Goal>();
    static int totalPoints = 0;

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Eternal Quest!");

        // Sample goals
        goals.Add(new SimpleGoal("Run a marathon", 1000));
        goals.Add(new EternalGoal("Read scriptures", 0));
        goals.Add(new ChecklistGoal("Go to the temple", 50, 5, 500));

        while (true)
        {
            ShowMenu();
        }
    }

    static void ShowMenu()
    {
        Console.WriteLine("\nMenu:");
        Console.WriteLine("1. View goals");
        Console.WriteLine("2. Record goal progress");
        Console.WriteLine("3. Exit");
        Console.Write("Choose an option: ");

        string choice = Console.ReadLine();
        switch (choice)
        {
            case "1":
                ViewGoals();
                break;
            case "2":
                RecordGoalProgress();
                break;
            case "3":
                Console.WriteLine("Goodbye!");
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Invalid choice. Try again.");
                break;
        }
    }

    static void ViewGoals()
    {
        Console.WriteLine("\nYour goals:");
        foreach (var goal in goals)
        {
            goal.DisplayGoal();
        }
        Console.WriteLine($"Total points: {totalPoints}");
    }

    static void RecordGoalProgress()
    {
        Console.WriteLine("\nWhich goal did you accomplish?");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].Name}");
        }

        Console.Write("Enter the goal number: ");
        if (int.TryParse(Console.ReadLine(), out int index))
        {
            index -= 1;
            if (index >= 0 && index < goals.Count)
            {
                int before = goals[index].Points;
                goals[index].RecordProgress();
                int after = goals[index].Points;
                int earned = after - before;
                totalPoints += earned;
                Console.WriteLine($"You earned {earned} points. Total points: {totalPoints}");
            }
            else
            {
                Console.WriteLine("Invalid goal number.");
            }
        }
        else
        {
            Console.WriteLine("Please enter a valid number.");
        }
    }
}
