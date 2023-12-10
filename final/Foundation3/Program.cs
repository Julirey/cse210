using System;

class Program
{
    static void Main(string[] args)
    {
        List<Event> events = new List<Event>();

        events.Add(new Lecture("The Power of Confidence", "Become a new You by discovering the power of confidence.", "December 8th, 2023", "5:00 PM", new Address("730 School St", "Webster", "Massachusetts"), "Drake Graham", 150));
        events.Add(new Reception("Homecoming Parade", "To wellcome all of those that came this far and endured every challenge.", "February 22th, 2024", "7:00 PM", new Address("110 Park Rd", "Burlingame", "California"), "nbhomecoming12@gmail.com"));
        events.Add(new OutdoorGathering("Bird Watching in the Wild", "An excursion to learn of the best places to watch birds.", "March 16th, 2024", "8:00 AM", new Address("101 Johnstone St", "Hampton", "South Carolina"), "Mostly Clear"));
    
        foreach (Event e in events)
        {
            Console.WriteLine("-Standard Details-");
            Console.WriteLine(e.GetStandardDetails());
            Console.WriteLine("-Full Details-");
            Console.WriteLine(e.GetFullDetails());
            Console.WriteLine("-Short Details-");
            Console.WriteLine(e.GetShortDetails());
            Console.WriteLine("----------------------------------");
        }
    }
}