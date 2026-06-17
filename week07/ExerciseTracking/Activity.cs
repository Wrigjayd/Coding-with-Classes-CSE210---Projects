public abstract class Activity
{
    private string _date;
    private double _minutes;
    public Activity(string date, double minutes)
    {
        _date = date;
        _minutes = minutes;
    }
    protected double GetMinutes()
    {
        return _minutes;
    }
    protected string GetDate()
    {
        return _date;
    }
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        string activityType = GetType().Name;
        string durationStr = $"{_minutes} min";
        string distanceStr = GetDistance().ToString("0.0");
        string speedStr = GetSpeed().ToString("0.1");
        string paceStr = GetPace().ToString("0.2");

        string result = GetDate() + ", " + activityType + ", " + durationStr + ":"
            + "Distance: " + distanceStr + " Mi, "
            + "Speed: " + speedStr + " MPH, "
            + "Pace: " + paceStr + " min per mile";

        return result;
    }
}