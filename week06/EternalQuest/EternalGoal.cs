class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points) { }

    public override void RecordEvent(ref int totalScore)
    {
        totalScore += _points;
        Console.WriteLine($"🔁 Recorded {_shortName}. +{_points} points.");
    }

    public override bool IsComplete() => false;

    public override string GetDetailsString() => $"[∞] {_shortName} ({_description})";

    public override string GetStringRepresentation() => $"EternalGoal|{_shortName}|{_description}|{_points}";
}
