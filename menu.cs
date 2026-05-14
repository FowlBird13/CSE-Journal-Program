using System;

/// <summary>
/// Create a custom menu that can allows the user to pick an option from a set.
/// The default options are Write, Display, Save, Load, and Quit.
/// </summary>
public class Menu
{
    // Create a list of tuples containing a name and a function.
    // Each of these items in the list is an "option" to choose from on the menu.
    // (As a side note, I learned about an "Action" which is a function that has 
    // no parameters and returns nothing)
    public List<(string Name, Action func)> _BmpOptions = new();
    
    /// <summary>
    /// This is an initializer. I didn't really know this was a thing before but basically
    /// it creates default values for the variables of any new Menu instance and doesn't 
    /// even need to be called. Wow!
    /// </summary>
    public Menu()
    {
        // Default methods are set to empty lambdas until I have the real functions
        _BmpOptions.Add(("Write", () => {}));
        _BmpOptions.Add(("Display", () => {}));
        _BmpOptions.Add(("Save", () => {}));
        _BmpOptions.Add(("Load", () => {}));
        _BmpOptions.Add(("Quit", () => {}));
    }

    /// <summary>
    /// Display the menu of options and ask for an integer input. Run's the corresponding 
    /// input's function. Returns nothing.
    /// </summary>
    public void bmpSelect()
    {
        for (int i = 0; i < _BmpOptions.Count(); i++)
        {
            Console.WriteLine($"\t{i}. {_BmpOptions[i].Name}");
        }
    }

    
}

