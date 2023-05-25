public class Scripture
{
    private Reference _reference;
    private string _text;
    private string _referenceText;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _text = text;
        _referenceText = _reference.GetReferenceText();
    }

    public void HideRandomWords()
    {
        string[] _words = _text.Split(' ');
        Random _random = new Random();

        List<int> _indexes = new List<int>();

        for (int i = 0; i < _words.Length; i++)
        {
            if (!_words[i].Contains("__________"))
            {
                _indexes.Add(i);
            }
        }

        if (_indexes.Count <= 4)
        {

            foreach (int _index in _indexes)
            {
                _words[_index] = "__________";
            }
        }
        else
        {
            int _count = _random.Next(1, 5);

            for (int i = 0; i < _count; i++)
            {
                int _randomIndex = _random.Next(0, _indexes.Count);
                int _selectedIndex = _indexes[_randomIndex];

                _words[_selectedIndex] = "__________";
                _indexes.RemoveAt(_randomIndex);
            }
        }

        _text = string.Join(' ', _words);
    }

    public bool HasWordsToHide()
    {
        string[] _words = _text.Split(' ');

        foreach (string _word in _words)
        {
            if (!_word.Contains("__________"))
            {
                return true; 
            }
        }

        return false;
    }

    public string GetRenderedText()
    {
        return _text;
    }

    public string GetReferenceText()
    {
        return _referenceText;
    }
}

