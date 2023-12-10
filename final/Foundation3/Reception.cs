using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Reception : Event
{   
    // Attributes
    private string _email;

    // Constructors
    public Reception(string title, string description, string date, string time, Address address, string email)
        : base(title, description,date, time, address)
    {
        _email = email;
    }

    // Methods
    public override string GetFullDetails()
    {   
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Type of Event: {this.GetType().Name}");
        sb.Append($"{GetStandardDetails()}");
        sb.AppendLine($"Email: {_email}");

        return sb.ToString();    
    }
}
