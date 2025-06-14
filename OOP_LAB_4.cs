using System;

class TextObject
{
    public string Text { get; set; }

    public TextObject(string text)
    {
        Text = text;
    }

    public void Print()
    {
        Console.WriteLine("Text: " + Text);
    }

    public int GetLength()
    {
        return Text.Length;
    }

    static void Main()
    {
        var obj = new TextObject("Hello World!");
        obj.Print();
        Console.WriteLine("Length: " + obj.GetLength());
    }
}