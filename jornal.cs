using System;
using System.IO;
public class Jornal{
    //All the entries
    List<Entry> _entries;
    

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
}