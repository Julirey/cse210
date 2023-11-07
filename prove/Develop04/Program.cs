using System;

// To exceed requirements I added a log that keeps track
// of the amount of times each activity has been done
// which can be viewed in the menu option number 4 called "Show Stats"
class Program
{
    static void Main(string[] args)
    {   
        int a1 = 0;
        int a2 = 0;
        int a3 = 0;

        while (true)
        {   
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Show Stats");
            Console.WriteLine("5. Quit");

            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            Console.Clear();
            if (choice == "1")
            {
                BreathingActivity activity = new BreathingActivity();
                activity.Run();
                a1++;
            }
            else if (choice == "2")
            {
                ReflectionActivity activity = new ReflectionActivity();
                activity.Run();
                a2++;
            }
            else if (choice == "3")
            {
                ListingActivity activity = new ListingActivity();
                activity.Run();
                a3++;
            }
            else if (choice == "4")
            {
                Console.WriteLine("----- Stats -----");
                Console.WriteLine();

                Console.WriteLine($"The amount of times you've done each activity will be shown.");
                Console.WriteLine();

                Console.WriteLine($"Breathing Activity: {a1}");
                Console.WriteLine($"Reflection Activity: {a2}");
                Console.WriteLine($"Listing Activity: {a3}");
                Console.WriteLine();

                Console.WriteLine("Press enter to return to the menu.");
                Console.ReadLine();
            }
            else
            {
                break;
            }
        }  
    }
}