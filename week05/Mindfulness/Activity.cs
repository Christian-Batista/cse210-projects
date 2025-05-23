using System;
public abstract class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity()
    {
        // Base constructor
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine(_description);
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Good job!");
        ShowSpinner(3);
        Console.WriteLine($"You have completed the {_name} activity for {_duration} seconds.");
        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            System.Threading.Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i} ");
            System.Threading.Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    public void ShowProgressBar(int seconds)
    {
        Console.Write("[");
        int width = 20;
        for (int i = 0; i < width; i++)
        {
            double percentage = (i + 1) / (double)width * 100;
            Console.Write($"={Math.Round(percentage)}%");
            Console.SetCursorPosition(Console.CursorLeft - 3, Console.CursorTop);
            Thread.Sleep(seconds * 1000 / width);
        }
        Console.WriteLine("] Done");
    }

    public abstract void Run();
}