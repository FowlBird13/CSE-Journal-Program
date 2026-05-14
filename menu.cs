using System.IO.Compression;
using Microsoft.VisualBasic;

/// <summary>
/// Create a custom menu that can allows the user to pick an option from a set.
/// The default options are Write, Display, Save, Load, and Quit.
/// </summary>
public class Menu
{
    // Create a list of dictionaries containing a name and a function.
    // Each of these items in the list is an "option" to choose from on the menu.
    // (As a side note, I learned about an Action which is a function that has no parameters and returns nothing)
    // public List<Dictionary<string, Action>> _BmpOptions;
    public List<Dictionary<string, Action>> _BmpOptions = new List<Dictionary<string, Action>>();
    
    /// <summary>
    /// This is an initializer. I didn't really know this was a thing before but basically
    /// it creates default values for the variables of any new Menu instance and doesn't 
    /// even need to be called. Wow!
    /// </summary>
    public Menu()
    {
        // Default methods are set to empty lambdas until I have the real functions
        _BmpOptions.Add(new Dictionary<string, Action>
        {
            {"Write", ()=>{}},
            {"Display", ()=>{}},
            {"Save", ()=>{}},
            {"Load", ()=>{}},
            {"Quit", ()=>{}}
        });
    }

    public void bmpSelect()
    {
        for (int i = 0; i < _BmpOptions.Count(); i++)
        {
            Console.WriteLine($"\t{i}. {_BmpOptions[i]}");
        }
    }

    
}

