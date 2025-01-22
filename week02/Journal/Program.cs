using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        Promptgenerator promptGenerator = new Promptgenerator();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nJournal Program");
            Console.WriteLine("1. Add Entry");
            Console.WriteLine("2. Display All Entries");
            Console.WriteLine("3. Save Journal to File");
            Console.WriteLine("4. Load Journal from File");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    string date = DateTime.Now.ToString("yyyy-MM-dd");
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"\nPrompt: {prompt}");
                    Console.Write("Your entry: ");
                    string entryText = Console.ReadLine();
                    Entry newEntry = new Entry(date, prompt, entryText);
                    journal.AddEntry(newEntry);
                    break;

                case "2":
                    Console.WriteLine("\nJournal Entries:");
                    journal.DisplayAll();
                    break;

                case "3":
                    Console.Write("Enter filename to save to: ");
                    string saveFile = Console.ReadLine();
                    try
                    {
                        journal.SaveToFile(saveFile);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error saving journal: {ex.Message}");
                    }
                    break;

                case "4":
                    Console.Write("Enter filename to load from: ");
                    string loadFile = Console.ReadLine();
                    try
                    {
                        journal.LoadFromFile(loadFile);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error loading journal: {ex.Message}");
                    }
                    break;

                case "5":
                    running = false;
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
