public class ChecklistGoal : Goal
{
    public int TimesCompleted { get; private set; }
    public int TargetCount { get; private set; }
    public int BonusPoints { get; private set; }

    public ChecklistGoal(string name, int points, int targetCount, int bonusPoints) : base(name, points)
    {
        TargetCount = targetCount;
        BonusPoints = bonusPoints;
        TimesCompleted = 0;
    }

    public override void RecordProgress()
    {
        if (TimesCompleted < TargetCount)
        {
            TimesCompleted++;
            Points += 50;

            Console.WriteLine($"'{Name}' completed {TimesCompleted}/{TargetCount} times.");

            if (TimesCompleted == TargetCount)
            {
                Points += BonusPoints;
                IsComplete = true;
                Console.WriteLine($"Bonus achieved! You earned {BonusPoints} bonus points!");
            }
        }
        else
        {
            Console.WriteLine($"'{Name}' goal is already completed.");
        }
    }

    public override void DisplayGoal()
    {
        string status = IsComplete ? "[X]" : "[ ]";
        Console.WriteLine($"{status} {Name} -- Completed {TimesCompleted}/{TargetCount} times");
    }
}
