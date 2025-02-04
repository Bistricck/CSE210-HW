using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void Display()
    {
        Console.WriteLine(_reference.GetDisplayText());
        Console.WriteLine(string.Join(" ", _words.Select(word => word.GetDisplayText())));
    }

    public void HideRandomWords(int count)
    {
        Random random = new Random();
        List<Word> availableWords = _words.Where(word => !word.IsHidden()).ToList();

        if (availableWords.Count == 0) return;

        int wordsToHide = Math.Min(count, availableWords.Count);
        for (int i = 0; i < wordsToHide; i++)
        {
            int index = random.Next(availableWords.Count);
            availableWords[index].Hide();
            availableWords.RemoveAt(index); // Prevent re-hiding already hidden words
        }
    }

    public bool IsFullyHidden()
    {
        return _words.All(word => word.IsHidden());
    }
}
