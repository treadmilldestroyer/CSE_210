using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string name = PromptUserName();

        int number = PromptUserNumber();
        
        int squaredNumber = SquareNumber(number);
        
        DisplayResult(name, squaredNumber);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.WriteLine("What is your name? ");
        string name = Console.ReadLine();

        return name;
    }
    static int PromptUserNumber()
    {
        Console.WriteLine("What is your favorite number? ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }
    static int SquareNumber(int number)
    {
        int newNumber = number * number;

        return newNumber;
    }
    static void DisplayResult(string name, int newNumber)
    {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Your favorite number squared is: {newNumber}");
    }
}