using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Goal
{   
    // Attributes
    protected string _description;
    protected string _name;
    protected int _points;

    // Constructors
    protected Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }
    
    // Methods
    public string GetName()
    {
        return _name;
    }
    public abstract string Display();

    public abstract string SaveString();

    public abstract bool IsCompleted();

    public abstract int RecordEvent();
}
