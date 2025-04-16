public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int points) : base(name, points) {}

    public override void RecordProgress()
    {
        if (!IsComplete)
        {
            IsComplete = true;
            Console.WriteLine($"'{Name}' completed! You earned {Points} points.");
        }
        else
        {
            Console.WriteLine($"'{Name}' is already completed.");
        }
    }

    public override void DisplayGoal()
    {
        string status = IsComplete ? "[X]" : "[ ]";
        Console.WriteLine($"{status} {Name}");
    }
}
