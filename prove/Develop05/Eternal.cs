using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Eternal : Goal
{   
    // Attributes

    private int _times;
    
    // Constructors
    public Eternal(string name, string description, int points)
        : base(name, description, points)
    {   
        _times = 0;
    }

    public Eternal(string name, string description, int points, int times)
        : base(name, description, points)
    {
        _times = times;
    }

    // Methods
    public override string Display()
    {
        return $"[ ] {_name} ({_description}) -- Times Completed: {_times}";
    }
    public override bool IsCompleted()
    {
        return false;
    }

    public override int RecordEvent()
    {
        _times++;
        return _points;
    }

    public override string SaveString()
    {
        return $"Eternal~~{_name}~~{_description}~~{_points}~~{_times}";
    }
}