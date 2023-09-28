using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {   
        int inputNumber = -1;
        List<int> numbers = new List<int>();

        int sumTotal = 0;
        float average = 0;
        int highestNumber = 0;

        while (inputNumber != 0)
        {
            Console.Write("Please enter a number: ");

            string answerString = Console.ReadLine();
            inputNumber = int.Parse(answerString);

            if (inputNumber != 0)
            {
                numbers.Add(inputNumber);
            }

        }

        foreach (int number in numbers)
        {
            sumTotal += number;
        }

        Console.WriteLine($"The sum is: {sumTotal}");

        average = ((float)sumTotal) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        foreach (int number in numbers)
        {
            if (number > highestNumber)
            {
                highestNumber = number;
            }
        }

        Console.WriteLine($"The largest number is: {highestNumber}");
    }   
}