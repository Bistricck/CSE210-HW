using System;
using System.Collections.Generic;
using System.IO;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public Entry(string date, string promptText, string entryText)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
    }

    public void Display()
    {
        Console.WriteLine($"Date; {_date}");
        Console.WriteLine($"prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
    }

    public string ToCsv()
    {
        return ($"{_date}, {_promptText}, {_entryText}");
    }


    public static Entry FromCsv(string csvLine)
    {
        var parts = csvLine.Split(',');
        if (parts.Length >= 3 )
        {
            return new Entry(parts[0], parts[1], parts[2]);
        }
        throw new FormatException("Invalid CSV format for Entry.");
    }
}
