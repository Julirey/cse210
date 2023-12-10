using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Event 
{   
    // Attributes
    private string _date;
    private string _title;
    private string _description;
    private string _time;
    private Address _address;

    // Constructors
    public Event(string title, string description,string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    // Methods
    public string GetStandardDetails()
    {   
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Title: {_title}");
        sb.AppendLine($"Description: {_description}");
        sb.AppendLine($"Date: {_date}");
        sb.AppendLine($"Time: {_time}");
        sb.AppendLine($"Address: {_address.GetAddress()}");
        
        return sb.ToString();
    }

    public string GetShortDetails()
    {   
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Type of Event: {this.GetType().Name}");
        sb.AppendLine($"Title: {_title}");
        sb.AppendLine($"Date: {_date}");

        return sb.ToString();
    }
    public virtual string GetFullDetails()
    {
        // It will be overriden by every sub class anyways
        // But by default it will display everything except
        // Information exclusive for a sub class of Event
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Type of Event: {this.GetType().Name}");
        sb.AppendLine($"{GetStandardDetails()}");

        return sb.ToString();
    }
}
