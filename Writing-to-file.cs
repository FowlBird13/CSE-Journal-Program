using System.IO;

string fileName = "journal.txt";

using (StreamWriter outputFile = new StreamWriter ("journal.txt"))
{
    outputFile.WriteLine("Example entry.");
    
}
