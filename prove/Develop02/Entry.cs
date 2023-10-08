using System;

public class Entry
{
    public string _date;
    public string _prompt;
    public string _response;

    public string GetDisplayString()
    {
        string displayString = @$"Date: {_date} - Prompt: {_prompt}
Answer: {_response}";
        return displayString;
    }
}