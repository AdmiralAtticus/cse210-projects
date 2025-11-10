public class JournalEntry
{
    public string _date;
    public string _prompt;
    public string _response;

    public void Display()
    {
        Console.WriteLine($"{_date} {_prompt} {_response}");
    }


    public void CreateJournalEntry()
    {
        _date = "11/10/2025";
        _prompt = "Wazzah?";
        Console.Write(_prompt);
        _response = Console.ReadLine();
    }

    public void CreateJournalEntry(string date, string prompt, string response)
    {
        _date = date;
        _prompt = prompt;
        _response = response;
    }
}