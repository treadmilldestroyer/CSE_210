using System;
using System.Runtime.CompilerServices;
public class Listing : Activity
{
    public Listing()
    {
        SetName("Listing Activity");
        SetDescription("This activity will help you see the good in your life by having you list as many things or people as you can in a certain category.");
    }
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

  public string PromptGen()
    {
        Random random = new Random();
        int i = random.Next(0, _prompts.Count);
        return _prompts[i];
    }

    public void TheExercise()
    {
        string prompt = PromptGen();
        int responseCount = 0;
        Console.WriteLine("List as many responses as you can.");
        Console.WriteLine($"{prompt}");
        Console.Write("You may begin in: ");
        Timer(5);
        Console.WriteLine();

        DateTime timeLimit = ActivityTimer(GetDuration());
        DateTime currentTime = DateTime.Now;
        while(DateTime.Now <= timeLimit)
        {
            Console.Write(">");
            Console.ReadLine();
            ++responseCount;
        }
        Console.WriteLine($"You listed {responseCount} responses.");

    }
}