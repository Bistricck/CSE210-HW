using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;


/// Base class for all mindfulness activities. Contains common attributes and behaviors.

class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }


    /// Displays the starting message for an activity and prompts the user for duration.

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Starting {_name} Activity");
        Console.WriteLine(_description);
        Console.Write("Enter duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());  // Get duration from user
        Console.WriteLine("Prepare to begin...");
        ShowSpinner(3);  // Pause before starting
    }


    /// Displays the ending message after completing an activity.

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Good job!");
        Console.WriteLine($"You have completed the {_name} activity for {_duration} seconds.");
        ShowSpinner(3);  // Pause before returning to menu
    }


    /// Displays a simple loading spinner animation for a given duration.

    protected void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    /// Displays a countdown timer to guide the user.

    protected void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"\r{i} seconds remaining...");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}
