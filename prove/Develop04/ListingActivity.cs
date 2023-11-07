using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

public class ListingActivity : Activity
{   
    // Attributes
    private List<string> _promptList = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    // Constructors
    public ListingActivity()
        : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {

    }

    // Methods
    private string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(0, _promptList.Count);
        return _promptList[number];
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("List as many responses as you can from the following prompt:");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.Write("You may begin in: ");
        DisplayCountdown(5);
        Console.WriteLine();

        Console.WriteLine();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        int counter = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write("> "); 
            Console.ReadLine();
            counter++;
        }
        Console.WriteLine();
        Console.WriteLine($"You listed {counter} items!");

        Console.WriteLine();
        DisplayEndingMessage();
    }
}