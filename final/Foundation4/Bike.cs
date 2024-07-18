public class Bike : Activity
{
    private double _speed;

    public Bike(string date, string activityType, int lengthTime, double speed) : base(date, activityType, lengthTime)
    {
        _speed = speed;
    }
    public override double CalculateDistance()
    {
        double distance = _speed * _lengthTime / 60;
        return Math.Round(distance,2);
    }

    public override double CalculateSpeed()
    {
        return _speed;
    }
    
    public override double CalculatePace()
    {
        return _lengthTime / CalculateDistance();
    }
}