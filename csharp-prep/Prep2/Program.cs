using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gradePercentage = Console.ReadLine();
        int gradePercentageInt = int.Parse(gradePercentage);

        string gradeLetter = "";

        if (gradePercentageInt >= 90)
        {
            gradeLetter = "A";
        }
        else if (gradePercentageInt >= 80) 
        {
            gradeLetter = "B";
        }
        else if (gradePercentageInt >= 70) 
        {
            gradeLetter = "C";
        }
        else if (gradePercentageInt >= 60) 
        {
            gradeLetter = "D";
        }
        else 
        {
            gradeLetter = "F";
        }

        Console.WriteLine($"Your grade is: {gradeLetter}");

        if (gradePercentageInt >= 70)
        {
            Console.WriteLine("You have passed, congrats!");
        }
        else
        {
            Console.WriteLine("You didn't pass, don't give up yet!");
            Console.WriteLine("You can always try next time!");
        }
    }
}