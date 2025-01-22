public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries are in the journal yet.");
        }
        else
        {
        foreach (var entry in _entries)
        {
            entry.Display();
        }
        }
    }
    public void SaveToFile(string file)
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine(entry.ToCsv());
            }
        }
        Console.WriteLine("Journal saved to file.");
    }   
     public void LoadFromFile(string file)
    {
         if (File.Exists(file))
        {
            _entries.Clear();
            foreach (var line in File.ReadAllLines(file))
            {
                try
                {
                    var entry = Entry.FromCsv(line);
                    _entries.Add(entry);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Skipped invalid entry in file.");
                }
            }
            Console.WriteLine("Journal loaded from file.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}