public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
// 1. constructor for NEW checklist goals
    public ChecklistGoal(string name, string description, string points, int target, int bonus) 
        : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }
    // 2. constructor specifically for LOADING saved checklist goals
    public ChecklistGoal(string name, string description, string points, int target, int bonus, int amountCompleted) 
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }

    public override void RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
            int pointsEarned = int.Parse(_points);

            if (_amountCompleted == _target)
            {
                pointsEarned += _bonus;
                Console.WriteLine($"Congratulations! You hit your target! You earned {_points} points plus a bonus of {_bonus} points!");
            }
            else
            {
                Console.WriteLine($"Congratulations! You earned {_points} points!");
            }
        }
        else
        {
            Console.WriteLine("This checklist goal has already been fully accomplished.");
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {        
        string statusSymbol;

        if (IsComplete())
        {
            statusSymbol = "[X]";
        }
        else
        {
            statusSymbol = "[ ]";
        }
    
        return $"{statusSymbol} {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_shortName},{_description},{_points},{_bonus},{_target},{_amountCompleted}";
    }
}