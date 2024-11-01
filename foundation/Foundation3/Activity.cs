using System;

public abstract class Activity
{
    private string date;
    private int duration; 

    public Activity(string date, int duration)
    {
        this.date = date;
        this.duration = duration;
    }

    public string Date => date;
    public int Duration => duration;

    
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{Date} {GetType().Name} ({Duration} min): Distance {GetDistance():0.0} km, " +
               $"Speed: {GetSpeed():0.0} kph, Pace: {GetPace():0.0} min per km";
    }
}
