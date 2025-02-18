class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent(ref int totalScore)
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
            totalScore += _points;

            if (_amountCompleted == _target)
            {
                totalScore += _bonus;
                Console.WriteLine($" Completed {_shortName}! Bonus +{_bonus} points.");
            }
            else
            {
                Console.WriteLine($" Progressed {_shortName}: {_amountCompleted}/{_target} (+{_points} points).");
            }
        }
        else
        {
            Console.WriteLine(" Goal is already fully completed.");
        }
    }

    public override bool IsComplete() => _amountCompleted >= _target;

    public override string GetDetailsString() => $"[{(_amountCompleted >= _target ? "X" : " ")}] {_shortName} ({_amountCompleted}/{_target})";

    public override string GetStringRepresentation() => $"ChecklistGoal|{_shortName}|{_description}|{_points}|{_target}|{_bonus}|{_amountCompleted}";
}
