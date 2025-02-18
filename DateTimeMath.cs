using System;

public class DateTimeMath
{
    // Main entry point for the program
    public static void Main(string[] args)
    {
        // Create the first event with a start and end date
        Event event1 = new Event
        (
            new DateTime(2024, 7, 1),  // Start date: July 1, 2024
            new DateTime(2024, 7, 10)  // End date: July 10, 2024
        );

        // Create the second event with a different start and end date
        Event event2 = new Event
        (
            new DateTime(2024, 7, 5),   // Start date: July 5, 2024
            new DateTime(2024, 7, 15)   // End date: July 15, 2024
        );
        
        // Output the duration of the first event in days
        Console.WriteLine($"Event 1 Duration: {event1.GetDuration()} days");

        // Output the duration of the second event in days
        Console.WriteLine($"Event 2 Duration: {event2.GetDuration()} days");

        // Check if the two events overlap and store the result in 'overlap'
        bool overlap = event1.IsOverLapping(event2);

        // Output whether the events overlap
        Console.WriteLine($"Events Overlap: {overlap}");
    }
}

public class Event
{
    // Fields to store the start and end date of the event
    public DateTime StartDate;
    public DateTime EndDate;

    // Constructor to initialize an Event with a start and end date
    public Event(DateTime StartDate, DateTime EndDate)
    {
        this.StartDate = StartDate; // Set the start date
        this.EndDate = EndDate;     // Set the end date
    }

    // Method to calculate the duration of the event in days
    public double GetDuration()
    {
        // Calculate the duration by subtracting the start date from the end date
        // The result is a TimeSpan object, and we use TotalDays to get the duration in days
        return (EndDate - StartDate).TotalDays;
    }

    // Method to check if the event overlaps with another event
    public bool IsOverLapping(Event otherEvent)
    {
        // Check if the events overlap by comparing their start and end dates
        // The events overlap if one event starts before the other ends and ends after the other starts
        return (StartDate < otherEvent.EndDate) && (EndDate > otherEvent.StartDate);
    }
}
