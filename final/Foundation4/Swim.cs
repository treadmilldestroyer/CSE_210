public class Swim : Activity
{
    private double _numLaps;

    public Swim(string date, string activityType, int lengthTime, double numLaps) : base(date, activityType, lengthTime)
    {
        _numLaps = numLaps;
    }

    public override double CalculateDistance()
    {
        return _numLaps * 50 / 1000;
    }

    public override double CalculateSpeed()
    {
        return CalculateDistance() / _lengthTime * 60;
    }
    
    public override double CalculatePace()
    {
        return 60 / CalculateSpeed();
    }

}
