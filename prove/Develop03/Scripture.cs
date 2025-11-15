using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    private Random _rand = new Random();


    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        foreach (string word in text.Split(" "))
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int count)
    {
        for (int i = 0; i < count; i++)
        {
            int index = _rand.Next(_words.Count);
            _words[index].Hide();
        }
    }

    public bool IsCompletelyHidden()
    {
        foreach (var word in _words)
        {
            if (!word.IsHidden())
            return false;
        }
        return true;
    }

    public string GetDisplayText()
    {
        string referenceText = _reference.GetReferenceText();

        List<string> pieces = new List<string>();
        foreach (var word in _words)
        {
            pieces.Add(word.GetDisplayText());
        }

        return $"{referenceText}\n{string.Join(" ", pieces)}";
    }
}