using System;
using System.Collections.Generic;

class Program
{
    static List<string> tasks = new List<string>();

    static void Main(string[] args)
    {
        bool appIsRunning = true;

        while (appIsRunning)
        {
            Console.WriteLine("===== ToDo App =====");
            Console.WriteLine("1. Aufgabe hinzufügen");
            Console.WriteLine("2. Aufgaben anzeigen");
            Console.WriteLine("3. Aufgabe als erledigt markieren");
            Console.WriteLine("4. Beenden");
            Console.Write("Wählen Sie eine Option: ");

            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    AddTask();
                    break;
                case "2":
                    ShowTasks();
                    break;
                case "3":
                    MarkTaskAsCompleted();
                    break;
                case "4":
                    appIsRunning = false;
                    break;
                default:
                    Console.WriteLine("Ungültige Option. Bitte wählen Sie erneut.");
                    break;
            }
        }
    }

    static void AddTask()
    {
        Console.Write("Geben Sie die neue Aufgabe ein: ");
        string newTask = Console.ReadLine();
        tasks.Add(newTask);
        Console.WriteLine("Aufgabe erfolgreich hinzugefügt.");
    }

    static void ShowTasks()
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("Keine Aufgaben vorhanden.");
        }
        else
        {
            Console.WriteLine("===== Aufgabenliste =====");
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i]}");
            }
        }
    }

    static void MarkTaskAsCompleted()
    {
        ShowTasks();
        Console.Write("Geben Sie die Nummer der abgeschlossenen Aufgabe ein: ");
        int taskIndex;
        if (int.TryParse(Console.ReadLine(), out taskIndex) && taskIndex > 0 && taskIndex <= tasks.Count)
        {
            tasks.RemoveAt(taskIndex - 1);
            Console.WriteLine("Aufgabe erfolgreich als erledigt markiert.");
        }
        else
        {
            Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine gültige Aufgabennummer ein.");
        }
    }
}
