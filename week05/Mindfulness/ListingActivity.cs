
/// An activity where the user lists as many items as possible related to a prompt.

class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt gratitude this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing", "This activity helps you reflect on the good things in your life by listing them.") { }

    public void Run()
    {
        DisplayStartingMessage();
        string prompt = GetRandomPrompt();  // Get a random prompt
        Console.WriteLine(prompt);
        ShowCountDown(3);  // Give the user a moment to prepare

        List<string> responses = GetListFromUser();
        Console.WriteLine($"You listed {responses.Count} items.");
        
        DisplayEndingMessage();
    }


    /// Selects a random prompt from the list.
 
    private string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }


    /// Allows the user to enter a list of responses until the duration expires.

    private List<string> GetListFromUser()
    {
        List<string> responses = new List<string>();
        int elapsed = 0;

        while (elapsed < _duration)
        {
            Console.Write("Enter an item: ");
            string input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input))
            {
                responses.Add(input);
            }
            elapsed += 2;  // Simulating that entering an item takes around 2 seconds
        }

        return responses;
    }
}
