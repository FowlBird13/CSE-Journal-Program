using System;

public class Entry
{
    public string _bmpDate = "<No Date>";
    public string _bmpPrompt = "<No Prompt>";
    public string _bmpWriting = "<No Writing>";

/// <summary>
/// Return the a formatted string of the date, prompt, and writing of the entry.
/// </summary>
/// <returns>string</returns>
    public string ToString()
    {
        string bmpNewString = 
        ($"{_bmpDate}\n{_bmpPrompt}\n{_bmpWriting}\n");
        return bmpNewString;
    }

/// <summary>
/// Run this to automatically set the Entry's date to today.
/// Formatted yyyy-MM-dd.
/// Returns nothing.
/// </summary>
    public void BmpSetDateToday()
    {
        DateTime bmpToday = DateTime.Now;
        _bmpDate = bmpToday.ToString("yyyy-MM-dd");
    }
}