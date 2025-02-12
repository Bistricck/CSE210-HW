
/// A breathing exercise that alternates between breathing in and breathing out.

class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity helps you relax by guiding you through deep breathing.") { }

    public void Run()
    {
        DisplayStartingMessage();
        int elapsed = 0;

        // Loop to continue breathing until the user-defined duration is reached
        while (elapsed < _duration)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(3);  // Pause for inhaling
            elapsed += 3;

            if (elapsed >= _duration) break;

            Console.WriteLine("Breathe out...");
            ShowCountDown(3);  // Pause for exhaling
            elapsed += 3;
        }

        DisplayEndingMessage();
    }
}
