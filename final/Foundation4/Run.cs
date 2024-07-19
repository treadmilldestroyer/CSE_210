using System.Security.Cryptography.X509Certificates;
public class Run : Activity
{
    private double _distance;

    public Run(string date, string activityType, int lengthTime, double distance) : base(date, activityType, lengthTime)
    {
        _distance = distance;
    }

    public override double CalculateDistance()
    {
        return _distance;
    }

    public override double CalculateSpeed()
    {
        double speed = CalculateDistance() / _lengthTime * 60;
        return Math.Round(speed,2);
    }
    
    public override double CalculatePace()
    {
        double pace = _lengthTime / CalculateDistance();
        return Math.Round(pace,2);
    }
}