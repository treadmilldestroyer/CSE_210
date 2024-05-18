using System;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    public static void Main()
    {
        
        string directory = Directory.GetCurrentDirectory();
        Console.WriteLine("Current Directory: " + directory);
        
        List<string> prompts = new List<string>
        {
            "What was the most fun thing that I did today?",
            "What was one thing that made me smile?",
            "What blessings am I grateful for today?",
            "Who did I not get to talk to that I wanted to?",
            "How was I an instument in the Lord's hands today?",
            "What gave you inspiration today?",
            "Rose, bud, thorn."
        };

        Journal journal = new Journal();
        Prompt promptGenerator = new Prompt();




        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Write Entry");
            Console.WriteLine("2. Display Entries");
            Console.WriteLine("3. Load A File");
            Console.WriteLine("4. Save Entries To A File");
            Console.WriteLine("5. Quit Program");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string randomPrompt = promptGenerator.GetRandomPrompt(prompts);
                    journal.AddEntry(randomPrompt);
                    break;
                case "2":
                    journal.DisplayEntries();
                    break;
                case "3":
                    Console.Write("Enter the file path to load entries from: ");
                    string loadfilePath = Console.ReadLine(); 
                    journal.LoadEntriesFromFile(loadfilePath);
                    break;
                case "4":
                    Console.Write("Enter a file to save the entries to.");
                    string filePath = Console.ReadLine();
                    journal.SaveEntryToFile(filePath);
                    break;
                case "5":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number from 1 to 5.");
                    break;
            }
        }        
    }
}

