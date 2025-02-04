using System;

class Program
{
    static void Main()
    {
        // Example scripture
        Reference scriptureRef = new Reference("Proverbs", 3, 5, 6);
        string text = "Trust in the Lord with all your heart and lean not on your own understanding.";
        Scripture scripture = new Scripture(scriptureRef, text);

        // Main loop
        while (!scripture.IsFullyHidden())
        {
            Console.Clear();
            scripture.Display();
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");

            string input = Console.ReadLine()?.Trim().ToLower();
            if (input == "quit")
                break;

            scripture.HideRandomWords(2); // Hide 2 words per iteration
        }

        Console.Clear();
        scripture.Display();
        Console.WriteLine("\nAll words are hidden. Program ending...");
    }
}

