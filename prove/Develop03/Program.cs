using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        string txt = "Let the wicked forsake their ways and the unrighteous their thoughts. Let them turn to the Lord, and he will have mercy on them, and to our God, for he will freely pardon.";
        Reference reference = new Reference("Isaiah", 55, 7);

        Scripture scripture = new Scripture(reference, txt);

        while(true)
        {   
            Console.Clear();
            scripture.DisplayScripture();
            Console.WriteLine();
            
            Console.Write("Press enter to hide words or type 'quit' to exit the program: ");
            string input = Console.ReadLine();

            if (input == "quit" )
            {
                break;
            }
            else
            {   
                if (scripture.IsCompletelyHidden() == true)
                {
                    break;
                }
                else
                {
                    scripture.HideWords();
                }
            }
        }
    }
}