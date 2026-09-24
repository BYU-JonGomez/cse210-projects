using System;
using System.Collections.Generic;

public class Entry
{
    public string _date; //variable to record
    public string _prompt; // variable to record
    public string _response; // variable to record

    public void Display() //questions generated, date and response displayed to be recorded
    {
        Console.WriteLine($"{_date} - {_prompt}"); // date and prompt to be recorded
        Console.WriteLine($"{_response}"); // response to be recorded.
    }
}