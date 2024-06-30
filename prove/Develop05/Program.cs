using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;


class Program
{
    protected static int _totalPoints = 0;
    private static List<Goal> listGoals = new List<Goal>();
    private static string _fileName;
    // static Program()
    // {
    //     _totalPoints = 0;
    // }
    static void Main(string[] args)
    {
        string choice = "";

        while (choice != "6")
        {
            Console.WriteLine(_totalPoints);
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Create New Goal:");
            Console.WriteLine("2. List Goals:");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.WriteLine("Select an option to continue.");
            choice = Console.ReadLine();

            switch (choice)
            { 
                case "1":
                    CreateNewGoal();
                    break;
                case "2":
                    ListGoals();
                    break;
                case "3":
                    SaveGoals();
                    break;
                case "4":
                    LoadGoals();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    Console.WriteLine("Exiting Program");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a correct number.");
                    break;

            }
        }
    }

    private static void CreateNewGoal()
    {
        Console.WriteLine("What type of goal would you like to create?");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        string goalTypeChoice = Console.ReadLine();


        switch (goalTypeChoice)
        {
            case "1":
                CreateGoal<Simple>();
                break;
            case "2":
                CreateGoal<Eternal>();
                break;
            case "3":
                CreateGoal<Checklist>();
                break;
            default:
                Console.WriteLine("Invalid goal type choice.");
                break;
        }
    }

    private static void CreateGoal<T>() where T : Goal, new()
    {
        T newGoal = new T();
        newGoal.CreateNewGoal(); 
        listGoals.Add(newGoal);
        Console.WriteLine($"{typeof(T).Name} goal created successfully.");
    }

    private static void ListGoals()
    {
        Console.WriteLine("List of Goals:");
        foreach (var goal in listGoals)
        {
            Console.WriteLine(goal.GetGoalForDisplay());
        }
    }

    private static void SaveGoals()
    {
        Console.WriteLine("Enter a file to save your goals to:");
        _fileName = Console.ReadLine();
        try
        {
            using (StreamWriter writer = new StreamWriter(_fileName))
            {
                foreach (Goal goal in listGoals)
                {
                    string goalData = $"{goal.GetSavedGoalString()}";
                    writer.WriteLine(goalData);
                }
            }

            Console.WriteLine("Goals saved successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving goals: {ex.Message}");
        }
    
    }

    private static void LoadGoals()
    {
        Console.WriteLine("Enter the file that contains the data you want to load:");
        _fileName = Console.ReadLine();
        try
            {
                listGoals.Clear();
                string[] lines = File.ReadAllLines(_fileName);

            foreach (string line in lines)
            {
                string[] parts = line.Split(';');

                if (parts.Length >= 4)
                {
                    string name = parts[0];
                    string description = parts[1];
                    int points = int.Parse(parts[2]);
                    int totalPoints = int.Parse(parts[3]);

                    _totalPoints += points;
                    Goal goal = new Simple(name, description, points);
                    // goal.AddPoints(); 

                    listGoals.Add(goal);

                    Console.WriteLine($"Loaded goal: {goal.GetGoalForDisplay()}");
                }
                else
                {
                    Console.WriteLine($"Invalid format for line: {line}");
                }
            }

            Console.WriteLine("Goals loaded successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading goals: {ex.Message}");
        }
    }


    private static void RecordEvent()
    {
        Console.WriteLine("Enter index of the goal to record event:");
        int index = int.Parse(Console.ReadLine());

        if (index >= 0 && index < listGoals.Count)
        {
            Goal selectedGoal = listGoals[index];
            selectedGoal.RecordEvent();
            if (selectedGoal.IsComplete())
            {
                selectedGoal.AddPoints(); 
                _totalPoints += selectedGoal.Points; 
            }
            

        }
        else
        {
            Console.WriteLine("Invalid goal index.");
        }
    }
}