using System;

public class Entry
{
    public string _bmpDate;
    public string _bmpPrompt;
    public string _bmpWriting;

/// <summary>
/// Return the a formatted string of the date, prompt, and writing of the entry.
/// </summary>
/// <returns>string</returns>
    public string ToString()
    {
        string bmpNewString = 
        ($"{_bmpDate}\n{_bmpPrompt}\n\n{_bmpWriting}");
        return bmpNewString;
    }

    public void BmpSetDate()
    {
        DateTime bmpToday = DateTime.Now;
        _bmpDate = bmpToday.ToString("yyyy-MM-dd");
    }
}