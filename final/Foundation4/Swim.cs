public class Swim : Activity
{
    private double _numLaps;

    public Swim(string date, string activityType, int lengthTime, double numLaps) : base(date, activityType, lengthTime)
    {
        _numLaps = numLaps;
    }

    public override double CalculateDistance()
    {
        double distance = _numLaps * 50 / 1000;
        return Math.Round(distance,2);
    }

    public override double CalculateSpeed()
    {
        double speed = CalculateDistance() / _lengthTime * 60;
        return Math.Round(speed,2);
    }
    
    public override double CalculatePace()
    {
        double pace = 60 / CalculateSpeed();
        return Math.Round(pace,2);
    }

}
