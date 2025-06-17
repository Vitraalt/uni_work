using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class VisitRecord
{
    public string Url { get; set; }
    public DateTime VisitTime { get; set; }
}

class Program
{
    static List<VisitRecord> visitHistory = new List<VisitRecord>();

    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;
        while (true)
        {
            Console.WriteLine("\n=== Меню Історії Відвідувань ===");
            Console.WriteLine("1. Додати відвідування");
            Console.WriteLine("2. Переглянути історію");
            Console.WriteLine("3. Видалити записи до певної дати");
            Console.WriteLine("4. Вийти");
            Console.Write("Оберіть опцію: ");

            string choice = Console.ReadLine();
            Console.Clear();

            switch (choice)
            {
                case "1":
                    AddVisit();
                    break;
                case "2":
                    ShowHistory();
                    break;
                case "3":
                    DeleteOldVisits();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Невірна опція. Спробуйте ще раз.");
                    break;
            }
        }
    }

    static void AddVisit()
    {
        Console.Write("Введіть URL сайту: ");
        string url = Console.ReadLine();
        Console.Write("Введіть дату і час відвідування (YYYY-MM-DD HH:MM) або залиште порожнім для поточного часу: ");
        string dateInput = Console.ReadLine();

        DateTime visitTime;
        if (string.IsNullOrWhiteSpace(dateInput))
        {
            visitTime = DateTime.Now;
        }
        else if (!DateTime.TryParse(dateInput, out visitTime))
        {
            Console.WriteLine("Невірний формат дати. Встановлено поточний час.");
            visitTime = DateTime.Now;
        }

        visitHistory.Add(new VisitRecord { Url = url, VisitTime = visitTime });
        Console.WriteLine("Відвідування додано.");
    }

    static void ShowHistory()
    {
        if (!visitHistory.Any())
        {
            Console.WriteLine("Історія порожня.");
            return;
        }

        Console.WriteLine("Історія відвідувань:");
        foreach (var visit in visitHistory)
        {
            Console.WriteLine($"{visit.VisitTime:yyyy-MM-dd HH:mm:ss} - {visit.Url}");
        }
    }

    static void DeleteOldVisits()
    {
        Console.Write("Введіть дату у форматі YYYY-MM-DD: ");
        string input = Console.ReadLine();

        if (DateTime.TryParse(input, out DateTime cutoffDate))
        {
            int beforeCount = visitHistory.Count;
            visitHistory = visitHistory.Where(v => v.VisitTime >= cutoffDate).ToList();
            int removed = beforeCount - visitHistory.Count;
            Console.WriteLine($"Видалено {removed} записів.");
        }
        else
        {
            Console.WriteLine("Неправильний формат дати.");
        }
    }
}