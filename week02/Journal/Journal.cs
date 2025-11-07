//Stores a list of journal entries

//Behaviours needed to display and store an entry:
//-Display the entry
//-Save the entry to a file
//-Load the entry from a file
//-Add an entry

//Attributes needed to support a journal:
//_entries: List<Entry>
//.................
//AddEntry(newEntry: Entry): void
//DisplayAll(): void
//SaveToFile((file: string): void
//LoadFromFile(file: string): void

using System;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        //Entry newEntry = new Entry();
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine();
        }
    }
    public void SaveToFile(string file)
    {
        string journal_str = "";
        foreach (Entry entry in _entries)
        {
            journal_str += $"{entry._date}|{entry._promptText}|{entry._entryText}\n";
        }
        File.AppendAllText(file, journal_str);

    }
    public void LoadFromFile(string file)
    {
        string[] lines = File.ReadAllLines(file);
        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            if (parts.Length == 3)
            {
                string date = parts[0];
                string promptText = parts[1];
                string entryText = parts[2];
                Entry loadedEntry = new Entry(date, promptText, entryText);
                _entries.Add(loadedEntry);
            }
        }
    }
}
