using System;
using System.Collections.Generic;


public class JournalEntry
{
    public string _date;
    public string _prompt;
    public string _response;

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Response: {_response}");
    }

    public void CreateJournalEntry(string prompt)
    {
        _date = DateTime.Now.ToString("MM/dd/yyyy");
        _prompt = prompt;

        Console.WriteLine($"\n{_prompt}");
        Console.Write("Your response: ");
        _response = Console.ReadLine();
    }

    public void CreateJournalEntry(string date, string prompt, string response)
    {
        _date = date;
        _prompt = prompt;
        _response = response;
    }


    public string GetEntryAsFileFormat()
    {
        return $"{_date}*{_prompt}*{_response}";
    }
    List<string> _prompts = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "What was something that challenged me today?",
        "How did I see the hand of the Lord in my life today?",
        "If I had one thing I could do over today, what would it be?",
        "What did I learn about myself today?",
        "What moment made me feel most alive today?"
    };


    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }
}