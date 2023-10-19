using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Word
{
    // Attributes
    private string _word;
    private bool _hidden;

    // Constructors
    public Word(string text)
    {
        if (string.IsNullOrEmpty(text))
        {
            throw new ArgumentException("Text cannot be null or empty.", nameof(text));
        }
        _word = text;
        _hidden = false;
    }

    // Methods
    public string GetRenderedWord()
    {   
        string renderedWord = _word;
        
        if (_hidden == false)
        {
            return renderedWord;
        }
        else 
        {
            renderedWord = string.Concat(Enumerable.Repeat("_", _word.Length));
            return renderedWord;
        }
    }

    public void Hide()
    {
        _hidden = true;
    }
    public void Show()
    {
        _hidden = false;
    }
    public bool IsHidden()
    {
        if (_hidden == true)
        {
            return true;
        }
        else 
        {
            return false;
        }
    }
}

