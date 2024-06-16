using System;
using System.Collections.Generic;

public class Reflection : Activity
{
    public Reflection()
    {
        SetName("Reflection Activity");
        SetDescription("This is a relaxing activity to help you reflect on times of success and strength.");
    }
        private List<string> _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you saw God helping you out.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you made progress on a goal.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you knew you were doing what was right.",
            "Think of a time when you did something truly selfless.",
            "Think of a time when you acted in faith."
        };

        private List<string> _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How can you apply this experience to something current in your life?",
            "What did you learn about yourself through this experience?",
            "What is your favorite thing about this experience?",
            "What did you learn most from this time?"
        };

        protected List<string> _usedQuestions = new List<string>();

    public string PromptGen()
    {
        Random random = new Random();
        int i = random.Next(0, _prompts.Count);
        return _prompts[i];
    }

    public string QuestionGen()
    {
        Random random = new Random();
        int i = random.Next(0, _questions.Count);
        return _questions[i];
    }
    
    public void TheExercise()
    {
        string prompt = PromptGen();

        Console.WriteLine("Think about the following prompt:");
        Console.WriteLine($"{prompt}");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to begin activity.");
        Console.ReadLine();
        Console.WriteLine("Now that you've thought a little about this, ponder on each of the following questions in regards to the prompt.");
        Console.Write("We'll begin in: ");
        Timer(8);
        Console.Clear();

        DateTime timeLimit = ActivityTimer(GetDuration());
        // DateTime currentTime = DateTime.Now;
        while (DateTime.Now <= timeLimit)
        {
            foreach (var q in _questions)
            {
                if (!_usedQuestions.Contains(q))
                {
                    string question = QuestionGen();
                    Console.Write($"{question} ");
                    _usedQuestions.Add(question);
                    Spinner(8);
                    Console.WriteLine();
                    Console.WriteLine();
                    
                    if (DateTime.Now > timeLimit)
                    {
                        break;
                    }
                }
            }
        }
    }
    
}