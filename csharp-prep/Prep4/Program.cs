using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> listNumbers = new List<int>();
        int number = -1;

        while (number != 0)
        {
            Console.WriteLine("Enter a list of numbers, type 0 when finished.");
            string numbers = Console.ReadLine();
            number = int.Parse(numbers);
            if (number != 0)
            {
                listNumbers.Add(number);
            }
        }    

        
        int sum = 0;
        int greatest = 0;
        foreach (int value in listNumbers)
        {
            sum += value;
            if (value > greatest)
            {
                greatest = value;
            }
        }
        Console.WriteLine($"The sum is: {sum}");
        int average = sum / listNumbers.Count;
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The greatest number is: {greatest}");

       



    }
}