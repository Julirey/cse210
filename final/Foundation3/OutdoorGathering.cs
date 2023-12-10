using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class OutdoorGathering : Event
{   
    // Attributes
    private string _weather;

    // Constructors
    public OutdoorGathering(string title, string description,string date, string time, Address address, string weather)
        : base(title, description,date, time, address)
    {
        _weather = weather;
    }

    // Methods
    public override string GetFullDetails()
    {   
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Type of Event: {this.GetType().Name}");
        sb.Append($"{GetStandardDetails()}");
        sb.AppendLine($"Weather Forecast: {_weather}");

        return sb.ToString();    
    }
}
