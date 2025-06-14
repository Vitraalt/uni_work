using System;

class DataObject
{
    public double A { get; set; }
    public double C { get; set; }
    public double D { get; set; }

    public DataObject(double a, double c, double d)
    {
        A = a;
        C = c;
        D = d;
    }

    public double ComputeExpression()
    {
        return (2 * C - D * Math.Sqrt(42 / D)) / (C + A - 1);
    }
}

class Program
{
    static void Main()
    {
        DataObject[] dataObjects = {
            new DataObject(1, 4, 2),
            new DataObject(2, 5, 3),
        };

        foreach (var obj in dataObjects)
        {
            Console.WriteLine($"Result: {obj.ComputeExpression():F2}");
        }
    }
}