using System;
using System.IO; 

// To exceed requirements, I added the option to show the total amount of words written 
// in the responses of the journal, it can be accessed via the program menu by selecting
// option 5.
class Program
{
    static void Main(string[] args)
    {   
        PromptGenerator promptGenerator = new PromptGenerator();
        Journal journal = new Journal();
        DateTime theCurrentTime = DateTime.Now;

        string choice = "";
        string filename = "";

        while (choice != "6")
        {   
            Console.WriteLine();
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Stats");
            Console.WriteLine("6. Quit");

            Console.Write("What would you like to do? ");

            choice = Console.ReadLine();
            
            if (choice == "1")
            {   
                string prompt = promptGenerator.GetPrompt();
                Console.WriteLine(prompt);
                string response = Console.ReadLine();
                string date = theCurrentTime.ToShortDateString();

                Entry entry = new Entry();
                entry._prompt = prompt;
                entry._response = response;
                entry._date = date;

                journal.AddEntry(entry);
            }
            else if (choice == "2")
            {
                journal.Display();
            }
            else if (choice == "3")
            {
                Console.WriteLine("What is the filename?");
                filename = Console.ReadLine();
                journal.Load(filename);
            }
            else if (choice == "4")
            {
                Console.WriteLine("What is the filename?");
                filename = Console.ReadLine();
                journal.Save(filename);
            }

            // To exceed requirements.
            else if (choice == "5")
            {
                journal.Stats();
            }
        }
    }
}