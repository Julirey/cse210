using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Swimming : Activity 
{   
    // Attributes
    private int _laps;
    
    // Constructors
    public Swimming(string date, int length, int laps)
        : base(date, length)
    {
        _laps = laps;
    }

    // Methods
    public override double GetDistance()
    {
        return Convert.ToDouble(_laps) * 50 / 1000;
    }

    public override double GetSpeed()
    {
        return GetDistance() / _length * 60;
    }
}
