using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Comment
{   
    // Attributes
    private string _name;
    private string _text;

    // Constructors
    public Comment(string name, string text)
    {
        _name = name;
        _text = text;
    }
    
    // Methods
    public string GetString()
    {
        return _name + " | " + _text;
    }
}
