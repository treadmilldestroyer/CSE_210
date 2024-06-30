public class Simple : Goal
{
    public Simple(string name, string description, int points) : base(name, description, points)
    {
        _yesComplete = false;
        _timeCompleted = string.Empty;
    }
    public Simple() : base("", "", 0)
    {

    }
    public override void CreateNewGoal()
    {
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of your goal? ");
        string description = Console.ReadLine();

        Console.Write("How many points are associated with your goal? ");
        string _stringpoints = Console.ReadLine();
        int points = int.Parse(_stringpoints);

        _name = name;
        _description = description;
        _points = points;
        _yesComplete = false;
        _timeCompleted = string.Empty;
    }

    public override bool IsComplete()
    {
        return _yesComplete;
    }

    public override void RecordEvent()
    {
        _yesComplete = true;
    }

    public override void AddPoints()
    {
        if (_yesComplete)
        {
            Console.WriteLine("You have already accomplished this goal.");
        }
        else
        {
            _totalPoints += _points; 
            Console.WriteLine($"Great job! You earned {_points} points!");
            _yesComplete = true;
            _timeCompleted = DateTime.Now.ToString();
        }

    }
    public override string GetGoalForDisplay()
    {
        return _yesComplete ? $"[X] {_name}  ({_description})" : $"[ ] {_name}  ({_description})";
    }
    public override string GetSavedGoalString()
    {
        return $"{_name};{_description};{_points};{_yesComplete}";
    }
    public override int Points => _points;
}