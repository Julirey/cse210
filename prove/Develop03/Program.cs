using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// To exceed requirements, I added a class that generates a list of scriptures
// and selects a random scripture for the program to use.
// I also added the option to show the words after they have been hidden.
class Program
{
    static void Main(string[] args)
    {   
        // To exceed requirements
        ScriptureGenerator scriptureGenerator = new ScriptureGenerator();
        scriptureGenerator.LoadScriptures();
        string[] parts = scriptureGenerator.GetScripture().Split('~'); 

        Reference reference;
        if (parts.Count() == 4 )
        {
            reference = new Reference(parts[0], int.Parse(parts[1]), int.Parse(parts[2]));
        }
        else
        {
            reference = new Reference(parts[0], int.Parse(parts[1]), int.Parse(parts[2]), int.Parse(parts[3]));
        }

        Scripture scripture = new Scripture(reference, parts.Last());

        while(true)
        {   
            Console.Clear();
            scripture.DisplayScripture();
            Console.WriteLine();
            
            Console.Write("Press enter to hide words, type 'show' to show all words or type 'quit' to exit the program: ");
            string input = Console.ReadLine();

            if (input == "quit" )
            {
                break;
            }
            
            // To exceed requirements
            else if (input == "show")
            {
                scripture.ShowWords();
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