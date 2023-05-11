public class Journal
{
    public string _userChoice ="";
    public string _userFile ="";

    public List<string> _entries = new List<string> ();


    public void Display()
    {
        foreach ( string entry in _entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void Save()
    {
        Console.WriteLine("Enter file name");
        Console.Write(">");
        _userFile = Console.ReadLine();
        using StreamWriter outputFile = new StreamWriter(_userFile);
        foreach(string entry in _entries)
        {
            outputFile.WriteLine(entry);
        }
    }

    public void Load()
    {
        string[] entry = System.IO.File.ReadAllLines(_userFile);
        foreach ( string line in entry)
        {
            string[] parts = line.Split(",");
            
        }
    }
}