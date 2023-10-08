using System;
using System.IO; 

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
            string[] parts = line.Split(",");

            string firstName = parts[0];
            string lastName = parts[1];
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
