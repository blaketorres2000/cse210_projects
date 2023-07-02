using System;

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of each type of event
        LectureEvent lectureEvent = new LectureEvent("Introduction to AI", "Learn about artificial intelligence", new DateTime(2023, 7, 1, 10, 0, 0), "123 Main Street", "John Doe", 50);
        ReceptionEvent receptionEvent = new ReceptionEvent("Company Party", "Celebrate our achievements", new DateTime(2023, 7, 15, 19, 0, 0), "456 Elm Street", "party@example.com");
        OutdoorGatheringEvent outdoorEvent = new OutdoorGatheringEvent("Picnic in the Park", "Enjoy outdoor activities", new DateTime(2023, 7, 10, 12, 0, 0), "789 Oak Street", "Sunny");

        // Generate and display marketing messages for each event
        Console.WriteLine(lectureEvent.GetStandardDetails());
        Console.WriteLine(lectureEvent.GetFullDetails());
        Console.WriteLine(lectureEvent.GetShortDescription());

        Console.WriteLine(receptionEvent.GetStandardDetails());
        Console.WriteLine(receptionEvent.GetFullDetails());
        Console.WriteLine(receptionEvent.GetShortDescription());

        Console.WriteLine(outdoorEvent.GetStandardDetails());
        Console.WriteLine(outdoorEvent.GetFullDetails());
        Console.WriteLine(outdoorEvent.GetShortDescription());
    }
}

