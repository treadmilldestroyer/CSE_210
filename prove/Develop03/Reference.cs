using System;
class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int? _endVerse; // _endVerse is nullable

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    // This constructor allows the user to give a reference with multiple verses. 
    public Reference(string book, int chapter, int verse, int? endVerse = null)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

// This function will use the _endVerse only if it has a value. This only happens if the user gives a second value
    public override string ToString()
    {
        return _endVerse.HasValue && _verse != _endVerse
            ? $"{_book} {_chapter}:{_verse}-{_endVerse}" : $"{_book} {_chapter}:{_verse}";
    }
}