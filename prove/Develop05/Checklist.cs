public class Checklist : Goal
{
    private int _bonusPoints;
    private int _eventsRequired;
    private int _eventsCompleted;


    public Checklist(string name, string description, int points) : base(name, description, points)
    {
    
    }
    public Checklist() : base("", "", 0)
    {
        
    }
    public override void CreateNewGoal()
    {
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of your goal? ");
        string description = Console.ReadLine();

        Console.Write("How many points are associated with your goal? ");
        string stringpoints = Console.ReadLine();
        int points = int.Parse(stringpoints);

        Console.Write("How many times does this goal need to be accomplished to receive a bonus? ");
        // string requirementForBonus = Console.ReadLine();
        int eventsRequired = int.Parse(Console.ReadLine());

        Console.Write("What is the bonus for accomplishing the goal that many times? ");
        string pointsBonus = Console.ReadLine();
        _bonusPoints = int.Parse(pointsBonus);

        _eventsCompleted = 0;

        _name = name;
        _description = description;
        _points = points;
        _eventsRequired = eventsRequired;
    }

        public override bool IsComplete()
    {
        if (_eventsCompleted >= _eventsRequired)
        {
            _yesComplete = true;
            return _yesComplete;
        }
        else 
        {
            _yesComplete = false;
            return _yesComplete;
        }
        // return _eventsCompleted >= _eventsRequired;
    }
        public override void RecordEvent()
    {
        _eventsCompleted++;
        Console.Clear();
        Console.WriteLine($"Progress recorded! Keep it up! You completed {_eventsCompleted} out of {_eventsRequired}!");
        Console.WriteLine($"Total Points: {_totalPoints}");
    }

    public override void AddPoints()
    {
        _totalPoints += _points;

        if (_eventsCompleted >= _eventsRequired)
        {
            _totalPoints += _bonusPoints;
            Console.WriteLine($"Congratulations, you fully completed your goal! You earned {_bonusPoints} bonus points!");
        }
        else
        {
            Console.WriteLine($"You earned {_points}! You have a grand total of {_totalPoints} points!");
        }
    }
    public override string GetGoalForDisplay()
    {
        return _yesComplete ? $"[X] {_name}  ({_description}) - {_eventsCompleted}/{_eventsRequired} events completed." : $"[ ] {_name}  ({_description}) - {_eventsCompleted}/{_eventsRequired} events completed.";
    }
    public override string GetSavedGoalString()
    {
        return $"{_name};{_description};{_points};{_totalPoints}";
    }
    public override int Points => _points;
}