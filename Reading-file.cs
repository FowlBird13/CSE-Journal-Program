

public class ReadFile
{

    /// <summary>
    /// This function contains all of the code that you wrote earlier. I had to move it into a class 
    /// and then a method in order to get the Main() method to run because the compiler didn't like 
    /// there being two "top level" functions. There can only be one Main()
    /// </summary>
    public void PlaceholderName()
    {
        string fileName = "journal.txt";
        string[] lines = System.IO.File.ReadAllLines("journal.txt");

        foreach (string line in lines)
        Console.Write(line);
    }

    
}
