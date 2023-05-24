using System;

public class Word
{
    private string _word;
    private bool _isHidden;

    public Word(string word)
    {
        _word = word;
        _isHidden = false;
    }

    public string GetWord()
    {
        if (_isHidden)
        {
            return "__________";
        }
        else
        {
            return _word;
        }
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public bool Hidden()
    {
        return _isHidden;
    }
}

