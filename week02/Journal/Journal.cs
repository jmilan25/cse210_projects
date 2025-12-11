using System.IO;
public class Journal
{
    List<Entry> _entries = new List<Entry>();


    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter("notes.txt"))
        {
            foreach (Entry entry in _entries)
            {
            outputFile.WriteLine($"{file}");

            }
        }

    }
    public void LoadFromFile(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split(" ");

            string firstName = parts[0];
            string lastName = parts[1];
        }

    }
}