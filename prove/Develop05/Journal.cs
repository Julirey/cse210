using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Journal
{
    // Attributes
    private List<Goal> _goals = new List<Goal>();
    private int _totalPoints = 0;

    // Constructors
    public Journal()
    {
    }

    // Methods
    public void DisplayMenu()
    {
        Console.WriteLine($"You have {_totalPoints} points");
        Console.WriteLine();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Create New Goal");
        Console.WriteLine("  2. List Goals");
        Console.WriteLine("  3. Save Goals");
        Console.WriteLine("  4. Load Goals");
        Console.WriteLine("  5. Record Event");
        Console.WriteLine("  6. Stats");
        Console.WriteLine("  0. Quit");
    }

    public void DisplayList()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].Display()}");
        }
    }
    public void DisplayListSimple()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
        }
    }

    public void Save(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {   
            outputFile.WriteLine(_totalPoints);

            foreach (Goal g in _goals)
            {
                outputFile.WriteLine(g.SaveString());
            }
        }
    }

    public void Load(string filename)
    {
        _goals.Clear();
        
        string[] lines = System.IO.File.ReadAllLines(filename);

        _totalPoints = int.Parse(lines[0]);

        foreach (string line in lines.Skip(1))
        {      
            string[] parts = line.Split("~~");

            if (parts[0] == "Simple")
            {
                Simple simple = new Simple(parts[1], parts[2], int.Parse(parts[3]), Convert.ToBoolean(parts[4]));
                _goals.Add(simple);
            }
            else if (parts[0] == "Eternal")
            {
                Eternal eternal = new Eternal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]));
                _goals.Add(eternal);
            }
            else if (parts[0] == "Checklist")
            {
                Checklist checklist = new Checklist(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]));
                _goals.Add(checklist);
            }
            else 
            {
                Console.WriteLine("That kind of goal doesn't exist");
            }
        }
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void SelectEvent(int index)
    {   
        if (!_goals[index - 1].IsCompleted())
        {
            int points = _goals[index - 1].RecordEvent();

            Console.WriteLine();
            Console.WriteLine($"Congratulations! You have earned {points} points!");

            _totalPoints += points;
            Console.WriteLine($"You now have {_totalPoints} points.");
        }
        else
        {
            Console.WriteLine("That Goal has already been completed.");
        }
    }

    // To exceed requirements
    public void DisplayStats()
    {
        Console.WriteLine("----- Statistics -----");
        Console.WriteLine();
        Console.WriteLine($"Total amount of goals: {_goals.Count}");
        Console.WriteLine();
        Console.WriteLine($"Simple Goals:     {GetOccurences(typeof(Simple))}");
        Console.WriteLine($"Eternal Goals:    {GetOccurences(typeof(Eternal))}");
        Console.WriteLine($"Checklist Goals:  {GetOccurences(typeof(Checklist))}");
        Console.WriteLine();
        Console.WriteLine($"Completed: {CountCompleted()} of {GetOccurences(typeof(Simple)) + GetOccurences(typeof(Checklist))}");
        Console.WriteLine("(Eternal Goals are not counted towards the total completed goals)");
    }

    // To exceed requirements
    public int CountCompleted()
    {
        int count = 0;
        foreach (Goal g in _goals)
            if (g.IsCompleted()) 
            {
                count++;
            }
        return count;
    }
    
    // To exceed requirements
    public int GetOccurences(Type goalType)
    {
        int count = 0;
        foreach (Goal g in _goals)
            if (g.GetType() == goalType) 
            {
                count++;
            }
        return count;
    }
    
}