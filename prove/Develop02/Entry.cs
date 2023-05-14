using System;
using System.Collections.Generic;

public class Entry
{
    public List<string> _entries = new List<string>();
    public DateTime _dateInfo = DateTime.Now;
    public Entry(){}

    public string DateToString()
    {
        string _dateString = _dateInfo.ToShortDateString();

        return _dateString;
    }
    
    public void DisplayEntries()
    {
        foreach (string entry in _entries)
        {
            Console.WriteLine(entry);
        }
    }
}