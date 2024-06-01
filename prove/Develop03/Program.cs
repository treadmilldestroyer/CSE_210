using System;
using System.Drawing;
using System.Threading;

class Program
{
    static void Main()
    {
        Scripture scripture = new Scripture("Now, concerning the state of the soul between death and the resurrection Behold, it has been made known unto me by an angel, that the spirits of all men, as soon as they are departed from this mortal body, yea, the spirits of all men, whether they be good or evil, are taken home to that God who gave them life. \nAnd then shall it come to pass, that the spirits of those who are righteous are received into a state of happiness, which is called paradise, a state of rest, a state of peace, where they shall rest from all their troubles and from all care, and sorrow.", "Alma", 40, 11, 12);
        
        while(true)
        {
            Console.Clear();
            scripture.DisplayScriptureAndReference();
            Console.WriteLine("\n\nPress Enter button to continue or type \"q\" to end program.");

            var key = Console.ReadKey(true);

            if (key.Key == ConsoleKey.Enter)
            {
                if (!scripture.HideRandomWord())
                {
                    Console.Clear();
                    scripture.DisplayScriptureAndReference();
                    Console.WriteLine("\nGreat job, you memorized the scripture.");
                    Console.WriteLine("If you don't have it all the way down, feel free to run the program again.");
                    break;
                }
            }
            else if (key.Key == ConsoleKey.R)
            {
                scripture.RevertToPrevState();
            }
            else if (key.Key == ConsoleKey.Q)
            {
                break;
            }
        }
    }    
}