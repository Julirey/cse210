using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Cycling : Activity 
{   
    // Attributes
    private double  _speed;

    // Constructors
    public Cycling(string date, int length, double speed)
        : base(date, length)
    {
        _speed = speed;
    }

    // Methods
    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetDistance()
    {
        return _speed * _length;
    }
}
