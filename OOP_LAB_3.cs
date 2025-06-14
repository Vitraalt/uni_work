using System;

class MyClass
{
    public char Value { get; set; }

    // Конструктор без параметрів
    public MyClass()
    {
        Value = '0';
    }

    // Конструктор з одним параметром
    public MyClass(char val)
    {
        Value = val;
    }

    // Метод для складання символів (перетворює на int, складає, повертає символ)
    public static MyClass operator +(MyClass a, MyClass b)
    {
        int result = (a.Value - '0') + (b.Value - '0');
        return new MyClass((char)(result + '0'));
    }

    public void Display()
    {
        Console.WriteLine($"Value: {Value}");
    }
}

class Program
{
    static void Main()
    {
        // Створення трьох об'єктів з різними конструкторами
        MyClass C1 = new MyClass();         // Конструктор без параметрів
        MyClass C2 = new MyClass('5');      // Конструктор з символом
        MyClass C3 = new MyClass('3');      // Ще один об'єкт для складання

        // Операція: C1 = C2 + C3
        C1 = C2 + C3;

        // Вивід результату
        Console.WriteLine("Результат складання C2 і C3 (поміщено в C1):");
        C1.Display();
    }
}