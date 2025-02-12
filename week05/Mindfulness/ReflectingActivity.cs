
/// An activity where the user reflects on past experiences and answers guided questions.

class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectingActivity() : base("Reflecting", "This activity helps you reflect on past experiences where you showed strength and resilience.") { }

    public void Run()
    {
        DisplayStartingMessage();
        string prompt = GetRandomPrompt();  // Get a random prompt
        Console.WriteLine(prompt);
        ShowSpinner(3);

        int elapsed = 0;
        while (elapsed < _duration)
        {
            Console.WriteLine(GetRandomQuestion());
            ShowSpinner(5);  // Pause before next question
            elapsed += 5;
        }

        DisplayEndingMessage();
    }


    /// Selects a random reflection prompt.
 
    private string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }

    /// Selects a random question for deeper reflection.

    private string GetRandomQuestion()
    {
        Random rand = new Random();
        return _questions[rand.Next(_questions.Count)];
    }
}
