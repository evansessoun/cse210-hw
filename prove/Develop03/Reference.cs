using System;
using System.Collections.Generic;

class Reference
{
    private string _book = string.Empty;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;
    private string _renderedText;

    public Reference(string book, int chapter, int startVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = 0;
    }
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    public string GetRenderedReference()
    {
        if (_endVerse == 0)
        {
            _renderedText = $"{_book} {_chapter}:{_startVerse}";
        }
        
        else if (!(_endVerse == 0))
        {
            _renderedText = $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        }
        return _renderedText;
    }
}