using System;
public abstract class Activity
{
    private DateTime _date;
    private int _minutes;

    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public DateTime Date => _date;
    public int Minutes => _minutes;

    // Abstract methods to be overridden by derived classes
    public abstract double GetDistance(); // in miles or km
    public abstract double GetSpeed();    // in mph or kph
    public abstract double GetPace();     // in min per mile or min per km

    // Virtual method that can be overridden if needed
    public virtual string GetSummary()
    {
        return $"{Date.ToString("dd MMM yyyy")} {GetType().Name} ({Minutes} min) - " +
               $"Distance: {GetDistance():F1} {(Program.UseKilometers ? "km" : "miles")}, " +
               $"Speed: {GetSpeed():F1} {(Program.UseKilometers ? "kph" : "mph")}, " +
               $"Pace: {GetPace():F1} min per {(Program.UseKilometers ? "km" : "mile")}";
    }
}