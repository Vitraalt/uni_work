using System;

abstract class Shape
{
    public abstract double GetArea();
    public abstract int GetLength();
}

class Rectangle : Shape
{
    public int Width { get; set; }
    public int Height { get; set; }

    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }

    public override double GetArea() => Width * Height;
    public override int GetLength() => Width + Height;
}

class Circle : Shape
{
    public int Radius { get; set; }

    public Circle(int radius)
    {
        Radius = radius;
    }

    public override double GetArea() => Math.PI * Radius * Radius;
    public override int GetLength() => Radius;
}

class Program
{
    static void Main()
    {
        Shape[] shapes = {
            new Rectangle(3, 4),
            new Circle(5)
        };

        foreach (var shape in shapes)
        {
            Console.WriteLine($"Area: {shape.GetArea()}, Length: {shape.GetLength()}");
        }
    }
}