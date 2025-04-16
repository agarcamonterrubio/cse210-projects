using System;

public abstract class Activity
{
    private DateTime date;
    private double duration; 

    public Activity(DateTime date, double duration)
    {
        this.date = date;
        this.duration = duration;
    }

    public DateTime Date { get { return date; } }
    public double Duration { get { return duration; } }

    public abstract double GetDistance(); 
    public abstract double GetSpeed(); 
    public abstract double GetPace(); 

    public string GetSummary()
    {
        return $"{Date.ToString("dd MMM yyyy")} {this.GetType().Name} ({Duration} min): Distance {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}
