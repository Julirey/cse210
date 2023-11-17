using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

public class Checklist : Goal
{   
    // Attributes
    private int _bonus;
    private int _times;
    private int _timesMax;

    // Constructors
    public Checklist(string name, string description, int points, int bonus, int timesMax)
        : base(name, description, points)
    {
        _bonus = bonus;
        _times = 0;
        _timesMax = timesMax;
    }
    public Checklist(string name, string description, int points, int bonus, int times, int timesMax)
        : base(name, description, points)
    {
        _bonus = bonus;
        _times = times;
        _timesMax = timesMax;
    }

    // Methods
    public override string Display()
    {
        if (!IsCompleted())
        {
            return $"[ ] {_name} ({_description}) -- Currently Completed: {_times}/{_timesMax}";
        }
        else
        {
            return $"[X] {_name} ({_description}) -- Currently Completed: {_times}/{_timesMax}";
        }
    }

    public override bool IsCompleted()
    {
        if (_times == _timesMax)
        {
            return true;
        }
        else 
        {
            return false;
        }
    }

    public override string SaveString()
    {
        return $"Checklist~~{_name}~~{_description}~~{_points}~~{_bonus}~~{_times}~~{_timesMax}";
    }

    public override int RecordEvent()
    {
        _times++;
        if (!IsCompleted())
        {
            return _points;
        }
        else
        {
            return _points + _bonus;
        }
    }
}