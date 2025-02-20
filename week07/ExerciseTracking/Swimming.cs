// Swimming Class
class Swimming : Activity
{
    private int laps;
    private const double LapLengthKm = 50.0 / 1000; // 50 meters per lap in km

    public Swimming(DateTime date, int minutes, int laps) : base(date, minutes)
    {
        this.laps = laps;
    }

    public override double GetDistance() => laps * LapLengthKm;
    public override double GetSpeed() => (GetDistance() / GetMinutes()) * 60;
    public override double GetPace() => GetMinutes() / GetDistance();
}