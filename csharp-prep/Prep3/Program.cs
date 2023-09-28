using System;
using System.Data;
using System.Diagnostics.Tracing;

class Program
{
    static void Main(string[] args)
    {
        string answer = "";
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        int guessNumber = -1;
        
        
        while (magicNumber != guessNumber)
        {
            Console.Write("What is your guess? ");
            answer = Console.ReadLine();
            guessNumber = int.Parse(answer);
            
            if (magicNumber > guessNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guessNumber)
            {
                Console.WriteLine("Lower");
            }
        }
        
        Console.Write("You guessed it!");
    }
}