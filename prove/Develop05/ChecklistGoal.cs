public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonus;


    public ChecklistGoal(string name, string description, int points, int targetCount, int bonus) : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonus = bonus;
        _currentCount = 0;
    }

    public override int RecordEvent()
    {
        if (_isComplete)
            return 0;

        _currentCount++;

        
        if (_currentCount >= _targetCount)
        {
            _isComplete = true;
            return Points + _bonus;
        }

        return Points;
    }


    public override string GetDetailsString()
    {
        string checkbox = _isComplete ? "[X]" : "[ ]";
        return $"{checkbox} {Name} - {Description} ({_currentCount}/{_targetCount})";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{Name}|{Description}|{Points}|{_targetCount}|{_bonus}|{_currentCount}|{IsComplete}";
    }
}

