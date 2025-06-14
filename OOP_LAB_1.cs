using System;

class Vector
{
    // Поля об'єкта
    public double X { get; set; }
    public double Y { get; set; }

    // Конструктор
    public Vector(double x, double y)
    {
        X = x;
        Y = y;
    }

    // Метод для виводу даних об'єкта
    public void PrintData()
    {
        Console.WriteLine($"Координати вектора: X = {X}, Y = {Y}");
    }

    // Метод для обчислення довжини вектора
    public double GetLength()
    {
        return Math.Sqrt(X * X + Y * Y);
    }

    // Метод для обчислення кута з віссю OX (в градусах)
    public double GetAngleWithOX()
    {
        double radians = Math.Atan2(Y, X);
        double degrees = radians * (180 / Math.PI);
        return degrees;
    }

    // Метод для виводу довжини та кута
    public void PrintLengthAndAngle()
    {
        Console.WriteLine($"Довжина вектора: {GetLength():F2}");
        Console.WriteLine($"Кут з віссю OX: {GetAngleWithOX():F2}°");
    }
}

// Демонстрація
class Program
{
    static void Main()
    {
        Vector vector = new Vector(3, 4);
        vector.PrintData();
        vector.PrintLengthAndAngle();
    }
}