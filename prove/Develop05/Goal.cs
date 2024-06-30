using System.Runtime.CompilerServices;

public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    protected int _totalPoints;
    protected bool _yesComplete;
    protected string _timeCompleted;




    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public abstract void CreateNewGoal();
    public abstract bool IsComplete();
    public abstract void RecordEvent();
    public abstract void AddPoints();
    public abstract string GetGoalForDisplay();
    public abstract string GetSavedGoalString();
    public abstract int Points { get; }
}