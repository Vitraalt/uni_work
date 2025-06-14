using System;

class TextObject
{
    public string Content { get; set; }

    public TextObject(string content)
    {
        Content = content;
    }

    public string ToUpper() => Content.ToUpper();
    public string Reverse() => new string(Content.Reverse().ToArray());

    public override string ToString() => Content;
}

class Program
{
    static void Main()
    {
        TextObject[] texts = {
            new TextObject("hello"),
            new TextObject("world"),
        };

        foreach (var text in texts)
        {
            Console.WriteLine($"Original: {text}");
            Console.WriteLine($"Uppercase: {text.ToUpper()}");
            Console.WriteLine($"Reversed: {text.Reverse()}");
        }
    }
}