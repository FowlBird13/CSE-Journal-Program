
string fileName = "journal.txt";
string[] lines = System.IO.File.ReadAllLines("journal.txt");

foreach (string line in lines)
Console.Write(line);