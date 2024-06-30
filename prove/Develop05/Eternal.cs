public class Eternal : Goal
{
    public Eternal(string name, string description, int points) : base(name, description, points)
    {

    }
    public Eternal() : base("", "", 0)
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

    }        

        public override bool IsComplete()
    {
        return false;
    }
        public override void RecordEvent()
    {
        _totalPoints += _points;
        Console.WriteLine($"Progress recorded! Keep it up! You earned {_totalPoints} points!");
    }

    public override void AddPoints()
    {
        _totalPoints += _points;
        Console.WriteLine($"You earned {_points}! You have a grand total of {_totalPoints} points!");

    }
    public override string GetGoalForDisplay()
    {
        return $"[ ] {_name}  ({_description})";
    }
    public override string GetSavedGoalString()
    {
        return $"{_name};{_description};{_points};{_totalPoints}";
    }
    public override int Points => _points;
}