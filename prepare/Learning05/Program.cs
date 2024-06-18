using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Square("Blue", 5));
        shapes.Add(new Rectangle("Azul", 2, 10));
        shapes.Add(new Circle("bleu", 15));
     

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"Color: {color}    Area: {area}");
        }
    }
}