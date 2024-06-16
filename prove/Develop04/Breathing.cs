using System;
public class Breathing : Activity
{
    public Breathing()
    {
        SetName("Breathing Activity");
        SetDescription("This is a relaxing activity that will walk you through a breathing exercise. Clear your mind and focus on your breathing.");
    }

    public void TheExercise()
    {
        DateTime timeLimit = ActivityTimer(GetDuration());
        DateTime currentTime = DateTime.Now;

        Console.Write("We'll begin in ");
        Timer(5);
        Console.Clear();
        Console.Write("Breathe in....");
        Timer(4);
        Console.WriteLine();
        Console.Write("Breath out....");
        Timer(4);

        while (currentTime <= timeLimit)
        {
            Console.WriteLine();
            Console.Write("Breathe in....");
            Timer(4);
            Console.WriteLine();
            Console.Write("Breath out....");
            Timer(4);
            Console.WriteLine();
            currentTime = DateTime.Now;
        }
    }
}