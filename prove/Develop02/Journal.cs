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

        Entry entry = new Entry();
        foreach (string line in lines)
        {      
            // It's supposed to go through the line, delete the extra strings
            string newLine = line.Replace("Date: ","").Replace("Prompt: ", "").Replace("Answer: ", "");
            string[] parts = newLine.Split(" - ");

            // Since I assume it can only go through one line at a time,
            // depending on the amount of items that the parts list gathered after the split,
            // the line will be processed accordingly.
            if (parts.Length == 2)
            {   
                entry._date = parts[0];
                entry._prompt = parts[1];
            }
            else
            {
                // I expect for the order to be always date and prompt first and the response second
                // So when the response gets saved, and the object has all the atributtes it needed for 
                // the entry to be completed and added to the list of entries.
                entry._response = parts[0];
                entries.Add(entry);
            }
            // And the cycle repeats again, but it doesn't load them as intended.
        }
    }
    public void Save(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in entries)
            outputFile.WriteLine(entry.GetDisplayString());
        }
    }
    public void Stats()
    {   
        int wordCount = 0;

        foreach (Entry entry in entries)
        {
            string line = entry._response;

            var charsToRemove = new string[] {",", ".", ";"};

            foreach (var c in charsToRemove)
            {
                line = line.Replace(c, string.Empty);
            }

            string[] words = line.Split(" ");
            
            wordCount += words.Length;
        }

        Console.WriteLine($"You have written a total of {wordCount} words in the journal.");
    }
}
