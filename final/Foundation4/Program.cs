using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running("8 Dec 2023", 15, 0.8));
        activities.Add(new Cycling("10 Dec 2023", 20, 6.5));
        activities.Add(new Swimming("16 Dec 2023", 40, 18));

        Console.WriteLine("Summary:");
        foreach (Activity activity in activities)
        {   
            Console.WriteLine(activity.GetSummary());
        }
    }
}