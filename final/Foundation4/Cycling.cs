public class Cycling : Activity
{
    private double _speed;

    public Cycling(string date, int lengthMinutes, double speed)
        : base(date, lengthMinutes)
    {
        _speed = speed;
    }

    public double GetSpeedValue()
    {
        return _speed;
    }

    public void SetSpeed(double speed)
    {
        _speed = speed;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetDistance()
    {
        return (_speed * GetLengthMinutes()) / 60;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }

    public override string GetSummary()
    {
        string summary = GetDate() + " Cycling (" + GetLengthMinutes() + " min): " +
                         "Distance " + GetDistance().ToString("0.0") + " miles, " +
                         "Speed " + GetSpeed().ToString("0.0") + " mph, " +
                         "Pace: " + GetPace().ToString("0.0") + " min per mile";
        return summary;
    }
}