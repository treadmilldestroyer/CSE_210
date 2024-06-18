using System;
public class Circle : Shape
{
    private double _radius;
    private double _pi = Math.PI;
    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }
    public override double GetArea()
    {
        return _radius * _pi;
    }
}