using System;

public class Ref
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int? _endVerse;

//     public Ref(string book, int chapter, int verse)
//         {
//             _book = book;
//             _chapter = chapter;
//             _verse = verse;
//         }
    
//     public void Display()
//     {
//         Console.WriteLine($"{_book} {_chapter}/{_verse}");
//     }
// }
    public Ref(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = null;
    }
    public Ref(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    public string GetReference()
    {
        return _endVerse.HasValue
            ? $"{_book} {_chapter}:{_verse}-{_endVerse}"
            : $"{_book} {_chapter}:{_verse}";
    }
}