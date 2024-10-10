using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Ref _reference;
    private List<Word> _words;

    public Scripture(Ref reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(int count)
    {
        Random random = new Random();
        var visibleWords = _words.Where(word => !word.IsHidden).ToList();

        for (int i = 0; i < count && visibleWords.Count > 0; i++)
        {
            var wordToHide = visibleWords[random.Next(visibleWords.Count)];
            wordToHide.IsHidden = true;
            visibleWords.Remove(wordToHide);
        }
    }

    public void Display()
    {
        Console.Clear();
        Console.WriteLine(_reference.GetReference());
        Console.WriteLine(string.Join(" ", _words.Select(word => word.GetDisplayText())));
    }

    public bool AreAllWordsHidden()
    {
        return _words.All(word => word.IsHidden);
    }
}