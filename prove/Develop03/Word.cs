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

    public string _getWord()
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

    public void _hide()
    {
        _isHidden = true;
    }

    public bool _hidden()
    {
        return _isHidden;
    }
}

