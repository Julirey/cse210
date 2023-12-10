using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Running : Activity 
{   
    // Attributes
    private double _distance;

    // Constructors
    public Running(string date, int length, double distance)
        : base(date, length)
    {
        _distance = distance;
    }

    // Methods
    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return _distance / _length * 60;
    }
}
