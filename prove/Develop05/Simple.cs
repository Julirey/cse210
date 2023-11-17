using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Simple : Goal
{   
    // Attributes
    private bool _completed;

    // Constructors
    public Simple(string name, string description, int points)
        : base(name, description, points)
    {
        _completed = false;
    }

    public Simple(string name, string description, int points, bool completed)
        : base(name, description, points)
    {
        _completed = completed;
    }

    // Methods
    public override string Display()
    {
        if (!IsCompleted())
        {
            return $"[ ] {_name} ({_description})";
        }
        else
        {
            return $"[X] {_name} ({_description})";
        }
    }

    public override bool IsCompleted()
    {
        return _completed;
    }

    public override int RecordEvent()
    {
        _completed = true;
        return _points;
    }
    public override string SaveString()
    {
        return $"Simple~~{_name}~~{_description}~~{_points}~~{_completed}";
    }
}