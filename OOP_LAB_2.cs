using System;

class Segment
{
    // Координати початку та кінця
    private double x1, y1, x2, y2;

    // Конструктор
    public Segment(double x1, double y1, double x2, double y2)
    {
        this.x1 = x1;
        this.y1 = y1;
        this.x2 = x2;
        this.y2 = y2;
    }

    // Деструктор
    ~Segment()
    {
        Console.WriteLine("Об'єкт Segment знищено");
    }

    // Метод отримання координат
    public void PrintCoordinates()
    {
        Console.WriteLine($"Початок: ({x1}, {y1})");
        Console.WriteLine($"Кінець:  ({x2}, {y2})");
    }

    // Метод обчислення довжини
    public double GetLength()
    {
        return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    }

    // Метод обчислення кута з віссю OX у градусах
    public double GetAngleWithOX()
    {
        double dx = x2 - x1;
        double dy = y2 - y1;
        double radians = Math.Atan2(dy, dx);
        return radians * (180 / Math.PI);
    }

    // Метод виводу довжини та кута
    public void PrintLengthAndAngle()
    {
        Console.WriteLine($"Довжина: {GetLength():F2}");
        Console.WriteLine($"Кут з OX: {GetAngleWithOX():F2}°");
    }
}

class Program
{
    static void Main()
    {
        Segment segment = new Segment(1, 2, 5, 6);
        segment.PrintCoordinates();
        segment.PrintLengthAndAngle();
    }
}