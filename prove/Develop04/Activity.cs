using System.Dynamic;

public class Activity
{
    protected string _message;
    protected string _name;
    protected string _description;
    protected int _duration;

  


    public void SetName(string name)
    {
        _name = name;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public void Duration()
    {
        Console.Write("How long, in seconds, would you like your activity to be? ");
        string time = Console.ReadLine();
        int breathingTime = int.Parse(time);
        SetDuration(breathingTime);
    }
    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void Ready()
    {
        Console.Clear();
        Console.WriteLine("Prepare to begin...");
        Spinner(3);
    }

    public void RunActivity()
    {
        Console.Clear();
        WelcomeMessage();
        Duration();
        Ready();
    }

    public void WelcomeMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine($"{_description}");
    }

    public void ExitMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Wonderful. Wasn't that relaxing?");
        Spinner(5);
        Console.WriteLine();
        Console.WriteLine($"You completed the {_name} for {_duration} seconds.");
        Spinner(5);
        Console.Clear();

    }

    public void Spinner(int spinnerTime)
    {
        List<string> animString =
        [
            "|",
            "/",
            "-",
            "\\",
            "|",
            "/",
            "-",
            "\\",
        ];

        int i = 0;
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(spinnerTime);
         while (DateTime.Now < endTime)
        {   
            string s = animString[i];
            Console.Write(s);
            Thread.Sleep(100);
            Console.Write("\b \b");
            i++;

            if (i >= animString.Count)
            {
                i = 0;
            }
        }
    }

    public DateTime ActivityTimer(int duration)
    {
        DateTime endTime = new DateTime();
        endTime = DateTime.Now.AddSeconds(duration);
        return endTime;
    }
    public void Timer(int duration)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            for (int i = duration; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }
    }


}