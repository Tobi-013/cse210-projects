public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
        
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Nice! You earned {GetPoints()} points.");
    }

    public override string GetStatus()
    {
        return $"[ ] {GetName()} ({GetDescription()})";
    }

    public override string GetStringRepresentation()
    {
       
        return $"EternalGoal:{GetName()},{GetDescription()},{GetPoints()}";

    }
    public override bool IsComplete()
    {
        return false;
    }
}