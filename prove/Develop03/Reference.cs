using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Reference
{
    // Attributes
    private string _book;
    private int _chapter;
    private int _verseStart;
    private int _verseEnd;

    // Constructors
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verse;
        _verseEnd = -1;
    }

    public Reference(string book, int chapter, int verseStart, int verseEnd)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verseStart;
        _verseEnd = verseEnd;
    }

    // Methods
    public string GetRenderedReference()
    {   
        string renderedReference;

        if (_verseEnd == -1)
        {
             renderedReference = $"{_book} {_chapter}:{_verseStart}";
            return renderedReference;
        }
        else 
        {
            renderedReference = $"{_book} {_chapter}:{_verseStart}-{_verseEnd}";
            return renderedReference;
        } 
    }
}
