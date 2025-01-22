public class Promptgenerator
{
    public List<string> _prompts;

    public Promptgenerator()
    {
        _prompts = new List<string>
        {
        "What are you grateful for today?",
        "What was the most interesting thing that happened today?",
        "How were you kind to other people today?",
        "What weird thing did you see today?",
        "What did you talk about today with a friend?",
        "What did the spirit tell me today?"
        };
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

}
