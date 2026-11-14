using System.Collections.Generic;
using System;
using System.IO;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();

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
        StreamWriter outputFile = new StreamWriter(file);
        foreach (Entry entry in _entries)
        {
            outputFile.WriteLine($"{entry.GetDate()}|{entry.GetPrompt()}|{entry.GetEntryText()}");
           
        }
        outputFile.Close();
    }

    public void LoadFromFile(string file)
    {
        _entries.Clear();
        string[] lines = File.ReadAllLines(file);
        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            if (parts.Length == 3)
            {
                string date = parts[0];
                string prompt = parts[1];
                string entryText = parts[2];
                Entry entry = new Entry(date, prompt, entryText);
                _entries.Add(entry);
            }
        }
    }
}