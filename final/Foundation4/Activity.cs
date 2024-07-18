using System.Runtime;

public abstract class Activity
{
    private string _date;
    private string _activityType;
    protected int _lengthTime;

    protected Activity(string date, string activityType, int lengthTime)
    {
        _date = date;
        _activityType = activityType;
        _lengthTime = lengthTime;
    }

    public abstract double CalculateDistance();
    public abstract double CalculateSpeed();
    public abstract double CalculatePace();

    public string GetSummary()
    {
        return $"{_date} {_activityType} ({_lengthTime} min): Distance {CalculateDistance()}km, Speed: {CalculateSpeed()}kph, Pace: {CalculatePace()} min per km";
    }

    
}