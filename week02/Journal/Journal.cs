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

    }
    public void LoadFromFile(string file)
    {

    }
}