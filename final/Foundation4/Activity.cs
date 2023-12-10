using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Activity 
{   
    // Attributes
    protected string _date;
    protected int _length;

    // Constructors
    protected Activity(string date, int length)
    {
        _date = date;
        _length = length;
    }

    // Methods
    public abstract double GetDistance();

    public abstract double GetSpeed();

    public double GetPace()
    {
        return 60 / GetSpeed();
    }

    public string GetSummary()
    {
        return $"{_date} {this.GetType().Name} ({_length} min)- Distance: {GetDistance():N2} km, Speed: {GetSpeed():N2} kph, Pace: {GetPace():N2} min per km";
    }
}
