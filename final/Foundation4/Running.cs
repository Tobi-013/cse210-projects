public class Running : Activity
{
    private double _distance;

    public Running(string date, int lengthMinutes, double distance)
        : base(date, lengthMinutes)
    {
        _distance = distance;
    }

    public double GetDistanceValue()
    {
        return _distance;
    }

    public void SetDistance(double distance)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / GetLengthMinutes()) * 60;
    }

    public override double GetPace()
    {
        return GetLengthMinutes() / _distance;
    }

    public override string GetSummary()
    {
        string summary = GetDate() + " Running (" + GetLengthMinutes() + " min): " +
                         "Distance " + GetDistance().ToString("0.0") + " miles, " +
                         "Speed " + GetSpeed().ToString("0.0") + " mph, " +
                         "Pace: " + GetPace().ToString("0.0") + " min per mile";
        return summary;
    }
}