using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Activity
{
    // Attributes
    private string _description;
    protected int _duration;
    private string _name;

    //  Constructors 
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    // Methods
    protected void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine($"{_description}");

        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Get ready . . .");
        DisplaySpinner(5);
        Console.WriteLine();
    }
    
    protected void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!!");
        DisplaySpinner(5);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        DisplaySpinner(5);
    }

    protected void DisplayCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            ClearCharacters(1);
        }
    }

    protected void DisplaySpinner(int seconds)
    {
        List<string> frames = new List<string>
        {
            "|",
            "/",
            "-",
            "\\",
        };  

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {   
            foreach (string frame in frames)
            {
                Console.Write(frame);
                Thread.Sleep(500);
                ClearCharacters(1);

                // In case the countdown ends before every item in the list gets displayed
                if (DateTime.Now > endTime)
                {
                    break;
                }
            }
        }
    }

    private void ClearCharacters(int charCount)
    {
        for (int i = 0; i < charCount; i++)
        {
            Console.Write("\b \b");
        }
    }
}
