using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Lecture : Event
{   
    // Attributes
    private string _speaker;
    private int _capacity;

    // Constructors
    public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity)
        : base(title, description,date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    // Methods
    public override string GetFullDetails()
    {   
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Type of Event: {this.GetType().Name}");
        sb.Append($"{GetStandardDetails()}");
        sb.AppendLine($"Speaker: {_speaker}");
        sb.AppendLine($"Capacity: {_capacity} people");

        return sb.ToString();    
    }
}
