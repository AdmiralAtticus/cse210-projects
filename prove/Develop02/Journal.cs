

using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;

public class Journal
{


    List<JournalEntry> _entries = new List<JournalEntry>();

    public void AddEntry(JournalEntry entry)
    {
        _entries.Add(entry);
    }

    public void Display()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("\nNo journal entries seen. \n");
            return;
        }
        Console.WriteLine("\nYour journal entries:\n");
        foreach (JournalEntry entry in _entries)
        {
            entry.Display();
        }
    }
    
    public void WriteToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (JournalEntry entry in _entries)
            {
                outputFile.WriteLine(entry.GetEntryAsFileFormat());
            }
        }
        Console.WriteLine("\nJournal Saved");
    }
    public void ReadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine($"\nFile '{filename}' not found.\n");
            return;
        }

        string[] lines = File.ReadAllLines(filename);
        _entries.Clear();

        foreach (string line in lines)
        {
            if (string.IsNullOrWhiteSpace(line))
                continue;

            string[] parts = line.Split('*');
            if (parts.Length < 3)
                continue;

            string date = parts[0].Trim();
            string prompt = parts[1].Trim();
            string response = parts[2].Trim();

            JournalEntry entry = new JournalEntry();
            entry.CreateJournalEntry(date, prompt, response);
            AddEntry(entry);
        }

        Console.WriteLine($"\nJournal loaded from '{filename}'.");

        }


    }
    
    


    