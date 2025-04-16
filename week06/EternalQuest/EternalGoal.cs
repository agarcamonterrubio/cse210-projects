public class EternalGoal : Goal
{
    public EternalGoal(string name, int points) : base(name, points) {}

    public override void RecordProgress()
    {
        Points += 100;
        Console.WriteLine($"'{Name}' recorded again! You earned 100 points. Total points: {Points}");
    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"[∞] {Name} (Eternal)");
    }
}
