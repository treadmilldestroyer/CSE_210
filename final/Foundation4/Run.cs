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
        return CalculateDistance() / _lengthTime * 60;
    }
    
    public override double CalculatePace()
    {
        return _lengthTime / CalculateDistance();
    }
}