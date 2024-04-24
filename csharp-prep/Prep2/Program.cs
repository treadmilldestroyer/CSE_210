using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();

        int gradePerc = int.Parse(grade);
        string letter = ("");

        if (gradePerc >= 90)
        {
            letter = "A";
        }
        else if (gradePerc >= 80)
        {
            letter = "B";
        }
        else if (gradePerc >= 70)
        {
            letter = "C";
        }
        else if (gradePerc >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine($"Your final grade: {letter}");

        if (gradePerc >= 70)
        {
            Console.Write("Congratulations on passing the class! Great Job! I am proud of you!");
        }
        else
        {
            Console.Write("Do not give up! You now have so much knowledge in this class, when you retake the class, you're going to crush it!");
        }

    }
}