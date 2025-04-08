public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int lengthMinutes, int laps)
        : base(date, lengthMinutes)
    {
        _laps = laps;
    }

    public int GetLaps()
    {
        return _laps;
    }

    public void SetLaps(int laps)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        double distance = _laps * 50.0 / 1000.0 * 0.62;
        return distance;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetLengthMinutes()) * 60;
    }

    public override double GetPace()
    {
        return GetLengthMinutes() / GetDistance();
    }

    public override string GetSummary()
    {
        string summary = GetDate() + " Swimming (" + GetLengthMinutes() + " min): " +
                         "Distance " + GetDistance().ToString("0.0") + " miles, " +
                         "Speed " + GetSpeed().ToString("0.0") + " mph, " +
                         "Pace: " + GetPace().ToString("0.0") + " min per mile";
        return summary;
    }
}