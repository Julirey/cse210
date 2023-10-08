using System;
using System.IO;
using System.Xml;
using Microsoft.VisualBasic.FileIO;

public class Journal
{
    public List<Entry> entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }
    public void Display()
    {
        foreach(Entry entry in entries)
        {
            Console.WriteLine(entry.GetDisplayString());
        }
    }
    public void Load(string filename)
    {   
        entries.Clear();
        
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {      
            string[] parts = line.Split("~~");

                Entry entry = new Entry();
                entry._date = parts[0];
                entry._prompt = parts[1];
                entry._response = parts[2];
                entries.Add(entry);
            
        }
    }
    public void Save(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in entries)
            outputFile.WriteLine($"{entry._date}~~{entry._prompt}~~{entry._response}");
        }
    }

    // Counts and prints the total amount of words written in the responses of the journal 
    public void Stats()
    {   
        // Sets the counter to zero 
        int wordCount = 0;

        // Goes through the responses of each entry 
        foreach (Entry entry in entries)
        {   
            string line = entry._response;

            // Removes the extra characters of the string 
            var charsToRemove = new string[] {",", ".", ";"};
            foreach (var c in charsToRemove)
            {
                line = line.Replace(c, string.Empty);
            }

            // Splits the string into words
            string[] words = line.Split(" ");
            
            // Sums the amount of words to the total
            wordCount += words.Length;
        }

        Console.WriteLine($"You have written a total of {wordCount} words in the journal.");
    }
}
