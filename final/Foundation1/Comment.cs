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
    
    // SMT I would make it more clear what these values represent by adding labels to the values
    // Methods
    public string GetString()
    {
        StringBuilder s = new StringBuilder();
        s.AppendLine($"Name: {_name}");
        s.AppendLine($"Comment: {_text}");

        return s.ToString();
    }
}
