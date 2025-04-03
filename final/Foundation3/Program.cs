using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Address address2 = new Address("456 Elm St", "Los Angeles", "CA", "USA");
        Address address3 = new Address("789 Park Ave", "Toronto", "ON", "Canada");

        Lecture lecture = new Lecture("Ted Talk", "Latest advancements in AI", "April 10, 2025", "10:00 AM", address1, "Dr. Smith", 100);
        Reception reception = new Reception("Networking Night", "Meet professionals in your industry", "April 15, 2025", "6:00 PM", address2, "rsvp@example.com");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Spring Festival", "Enjoy a fun day in the park", "April 20, 2025", "12:00 PM", address3, "Sunny with a chance of rain");

        Console.WriteLine("\n=== Lecture Details ===");
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine("\nShort Description:");
        Console.WriteLine(lecture.GetLectureShortDescription());

        Console.WriteLine("\n=== Reception Details ===");
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine("\nShort Description:");
        Console.WriteLine(reception.GetReceptionShortDescription());

        Console.WriteLine("\n=== Outdoor Gathering Details ===");
        Console.WriteLine(outdoorGathering.GetFullDetails());
        Console.WriteLine("\nShort Description:");
        Console.WriteLine(outdoorGathering.GetOutdoorShortDescription());
    }
}