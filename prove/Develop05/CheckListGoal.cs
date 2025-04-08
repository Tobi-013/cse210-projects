public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
        _currentCount = 0; 
    }

    public int GetTargetCount()
    {
        return _targetCount;
    }

    public void SetTargetCount(int targetCount)
    {
        _targetCount = targetCount;
    }

    public int GetCurrentCount()
    {
        return _currentCount;
    }

    public void SetCurrentCount(int currentCount)
    {
        _currentCount = currentCount;
    }

    public int GetBonusPoints()
    {
        return _bonusPoints;
    }

    public void SetBonusPoints(int bonusPoints)
    {
        _bonusPoints = bonusPoints;
    }

    public override void RecordEvent()
    {
        
        _currentCount++;

       
        Console.WriteLine($"Great! You earned {GetPoints()} points for this event.");

        
        if (IsComplete())
        {
            Console.WriteLine($"Bonus! You earned an extra {_bonusPoints} points for completing the checklist!");
        }
    }

    public override bool IsComplete()
    {
        return _currentCount >= _targetCount;
    }

    public override string GetStatus()
    {
        string checkbox;
        if (IsComplete())
        {
            checkbox = "X";
        }
        else
        {
            checkbox = " ";
        }
        return $"[{checkbox}] {GetName()} ({GetDescription()}) -- Completed: {_currentCount}/{_targetCount}";
    }

    public override string GetStringRepresentation()
    {
       
        return $"ChecklistGoal:{GetName()},{GetDescription()},{GetPoints()},{_targetCount},{_currentCount},{_bonusPoints}";
    }
}