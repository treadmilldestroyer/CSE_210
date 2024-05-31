using System;

class Program
{
    static void Main()
    {
        Scripture scripture = new Scripture("Now, concerning the state of the soul between death and the resurrection Behold, it has been made known unto me by an angel, that the spirits of all men, as soon as they are departed from this mortal body, yea, the spirits of all men, whether they be good or evil, are taken home to that God who gave them life. \nAnd then shall it come to pass, that the spirits of those who are righteous are received into a state of happiness, which is called paradise, a state of rest, a state of peace, where they shall rest from all their troubles and from all care, and sorrow.", "Alma", 40, 11, 12);
        Console.Clear();
        scripture.DisplayScriptureAndReference();
        Console.WriteLine("\n\nPress Enter button to continue or type \"quit\" to end program.");

        while (true)
        {
            string userInput = Console.ReadLine();
            if (userInput.ToLower() == "quit")
                break;

            if (!scripture.HideRandomWord())
            {
                Console.WriteLine("Great job, you memorized the scripture.");
                Console.WriteLine("If you don't have it all the way down, feel free to run the program again.");
                break;
            }

            Console.Clear();
            scripture.DisplayScriptureAndReference();
            Console.WriteLine("\n\nPress Enter button to continue or type \"quit\" to end program.");
        }
    }
}