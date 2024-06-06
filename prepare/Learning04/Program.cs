using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Aaron", "Counting");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment math1 = new MathAssignment("Aaron", "Math", "Section 1", "#1-5");
        Console.WriteLine(assignment1.GetSummary());
        Console.WriteLine(math1.GetHomeworkList());

        WritingAssignment write1 = new WritingAssignment("Aaron", "English", "Title of Book");
        Console.WriteLine(assignment1.GetSummary());
        Console.WriteLine(write1.GetWritingInformation());    
    }
}