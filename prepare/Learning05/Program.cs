using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Square s1 = new Square("red", 4);
        Console.WriteLine(s1.GetColor());
        Console.WriteLine(s1.GetArea());

        Rectangle r1 = new Rectangle("blue", 4, 5);
        Console.WriteLine(r1.GetColor());
        Console.WriteLine(r1.GetArea());

        Circle c1 = new Circle("orange", 6);
        Console.WriteLine(c1.GetColor());
        Console.WriteLine(c1.GetArea());

        List<Shape> shapes = new List<Shape>();
        shapes.Add(s1);
        shapes.Add(r1);
        shapes.Add(c1);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"The {shape.GetColor()} shape has an area of {shape.GetArea()}.");
        }
    }
}