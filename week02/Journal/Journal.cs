using System.Security.Cryptography.X509Certificates;

public class Journal()
{
    public List<Entry> _entries = new List<Entry>();
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }
    public void DisplayAll()
    {
        foreach(Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public void SaveToFile(string fileName)
    {
        using(StreamWriter writer = new StreamWriter(fileName))
        foreach(Entry entry in _entries)
        {
            writer.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
        }
    }
    public void LoadFromFile(string fileName)
    {
        string[] lines = File.ReadAllLines(fileName);
        foreach(string line in lines)
        {
            string[] parts = line.Split("|");

            Entry entry = new Entry();
            entry._date = parts[0];
            entry._promptText = parts[1];
            entry._entryText = parts[2];

            _entries.Add(entry);
        }
    }

    public void ShowSummary()
    {
        Console.WriteLine($"Total entries: {_entries.Count}");

        if (_entries.Count > 0)
        {
            Console.WriteLine($"First entry date: {_entries[0]._date}");
            Console.WriteLine($"Latest entry date: {_entries[_entries.Count - 1]._date}");
        }
        else
        {
            Console.WriteLine("No entries found.");
        }
    }
    

}