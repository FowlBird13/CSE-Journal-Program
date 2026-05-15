using System;
using System.IO;
public class Jornal{
    //All the entries
    public List<Entry> _entries = [];
    
    //A list that menu will pull up a prompt from when a user selects 1. write
    public List<string> _prompts = new List<string> {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"};

    public void saveEntriesToJornal(List<Entry> newEntries)
    {//this will save all the entries from the user
        _entries = newEntries;
    }
    public void saveJornalAsFile()
    {
        Console.WriteLine("What is the file name?");
        string filelName = Console.ReadLine();    
        using (StreamWriter saveJornal = new StreamWriter(filelName))
        {
            foreach(Entry entry in _entries)
            {
                saveJornal.WriteLine(entry);
            }
        }
        Console.WriteLine($"Your jornal is successfuly saved in {filelName}.");
        
    }
    public void displayJornal()
    {
        //displays all jornal contents line by line
        foreach(Entry entry in _entries)
        {
            Console.WriteLine(line);
        }
    }
    public string[] loadJornal()
    {   
        bool notLoaded = true;
        while (notLoaded){
        try
        {
        //load a jornal that matches user's input
        Console.WriteLine("What is the file name?");
        string filelName = Console.ReadLine();
        string[] jornal = System.IO.File.ReadAllLines(fileName);
        notLoaded = false;
        } 
        catch (FileNotFoundException)
        {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"No jornal named {fileName}.");
                Console.ResetColor();
        }
        catch (FileLoadException)
        {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Failed to load the jornal. Try again.");
                Console.ResetColor();        
                }
        return jornal;
        }
    }

    /// <summary>
    /// Prompts the user to create a new Entry with today's date and a random prompt.
    /// Automatically adds the entry to the active Journal.
    /// </summary>
    public void BmpWriteEntry()
    {
        Entry bmpNewEntry = new Entry();
        bmpNewEntry.BmpSetDateToday();
        

        Random bmpRandNum = new Random();
        string bmpNewPrompt = _prompts[bmpRandNum.Next(_prompts.Count())];
        bmpNewEntry._bmpPrompt = bmpNewPrompt;
        Console.WriteLine(bmpNewPrompt);

        //This try and do-while loop prevent empty responses in the entry.
        bool bmpNullReferenceFlag;
        do {
            try
            {

                
                string bmpWriting = Console.ReadLine();
                if (bmpWriting == "")
                {
                    throw new NullReferenceException();
                }
                bmpNewEntry._bmpWriting = bmpWriting;
                bmpNullReferenceFlag = false;
            } catch (NullReferenceException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please enter valid text for the prompt.");
                Console.ResetColor();
                bmpNullReferenceFlag = true;
            }
        } while (bmpNullReferenceFlag);

        _entries.Add(bmpNewEntry);
    }
}