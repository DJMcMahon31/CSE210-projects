//Represents a single journal entry

//Behaviours needed to support an entry:
//-Display the entry (Display(): void)

//Attributes needed to support an entry:
//_date:string
//_promptText:string
//_EntryText:string
//.................
//Display(): void


using System;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
    }
}