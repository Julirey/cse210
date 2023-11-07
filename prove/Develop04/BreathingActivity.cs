using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class BreathingActivity : Activity
{   
    // No attributes needed on this class

    // Constructors
    public BreathingActivity() 
        : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on breathing.")
    {

    }

    // Methods
    public void Run()
    {
        DisplayStartingMessage();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            ShowBreathInMessage(4);
            ShowBreathOutMessage(6);  
            Console.WriteLine();
        }

        DisplayEndingMessage();
    }

    private void ShowBreathInMessage(int duration)
    {
        Console.Write($"Breathe in... ");
        DisplayCountdown(duration);
        Console.WriteLine();
    }

    private void ShowBreathOutMessage(int duration)
    {
        Console.Write($"Now breathe out... ");
        DisplayCountdown(duration);
        Console.WriteLine();
    }
}
