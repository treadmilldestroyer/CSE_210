using System;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";

        // bool exit = false;
        while(choice != "4")
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine("Select an option to continue.");
            choice = Console.ReadLine();

            switch(choice)
            {
                case "1":
                    Breathing breathingActivity = new Breathing();
                    breathingActivity.RunActivity();
                    breathingActivity.TheExercise();
                    breathingActivity.ExitMessage();
                    break;
                case "2":
                    Reflection reflectionActivity = new Reflection();
                    reflectionActivity.RunActivity();
                    reflectionActivity.TheExercise();
                    reflectionActivity.ExitMessage();
                    break;
                case "3":
                    Listing listingActivity = new Listing();
                    listingActivity.RunActivity();
                    listingActivity.TheExercise();
                    listingActivity.ExitMessage();
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Please enter one of the correct menu options.");
                    break;
                

                

            }
        }
   
    }
}