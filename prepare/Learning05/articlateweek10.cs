

public abstract class Shape
{
    ...
    public abstract double Area();
}

public class Rectangle : Shape
{
        public override double GetArea()
    {
        return _length * _width;
    }
}