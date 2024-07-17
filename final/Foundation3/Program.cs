using System;

class Program
{
    static void Main(string[] args)
    {
        
        Address address = new Address("123 Main St.", "Rexburg", "Idaho", "80224");
        Address address2 = new Address("321 Boulevard", "Lehi", "Utha", "98765");
        Address address3 = new Address("456 Avenue", "San Antonio", "Texas", "90123");
        
        Lecture lecture = new Lecture("Lecture", "Lecture 101", "This is going to be a fun lecture", "03/24/25", "1:00PM", address, "Samuel", 200);
        Reception reception = new Reception("Reception", "The Arnold's Wedding Reception", "This is celebrating the sealing of Eve and Aaron Arnold", "12/28/24", "4:00", address2, "testemail@email.com");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Outdoor Gathering", "Arnold Annual Bonfire", "Come have a ball at the ranch", "07/04/25", "2:00PM", address3, "Sunny and hot");
        
        Console.WriteLine("Lecture Event");
        Console.WriteLine(lecture.StandardDetails());
        Console.WriteLine();
        Console.WriteLine(lecture.FullDetails());
        Console.WriteLine();
        Console.WriteLine(lecture.ShortDescription());
        Console.WriteLine("--------------------------------------------------------------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine("Reception Event");
        Console.WriteLine(reception.StandardDetails());
        Console.WriteLine();
        Console.WriteLine(reception.FullDetails());
        Console.WriteLine();
        Console.WriteLine(reception.ShortDescription());
        Console.WriteLine("--------------------------------------------------------------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine("Outdoor Gathering Event");
        Console.WriteLine(outdoorGathering.StandardDetails());
        Console.WriteLine();
        Console.WriteLine(outdoorGathering.FullDetails());
        Console.WriteLine();
        Console.WriteLine(outdoorGathering.ShortDescription());
    }
}