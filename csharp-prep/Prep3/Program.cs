using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int answerNumber = randomGenerator.Next(1, 100);
        
        // Console.WriteLine("What is the magic number? ");
        // string magicNumber = Console.ReadLine();
        // int answerNumber = int.Parse(magicNumber);

        Console.WriteLine("What is your guess? ");
        string userGuess = Console.ReadLine();
        int guess = int.Parse(userGuess);
        int count = 1;

        while (guess != answerNumber)
            if (guess < answerNumber)
            {
                Console.WriteLine("Higher");
                guess = int.Parse(Console.ReadLine());
                count += 1;
            }
            else
            {
                Console.WriteLine("Lower");
                guess = int.Parse(Console.ReadLine());
                count += 1;
            }
        if (guess == answerNumber)
        {
            Console.WriteLine("You got it!");
            Console.WriteLine($"It took you {count} guesses.");
        }




    }
}