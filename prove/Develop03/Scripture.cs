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

        List<int> _indexes = new List<int>(); // Create a list to store the available indices

        for (int i = 0; i < _words.Length; i++)
        {
            if (!_words[i].Contains("__________")) // Only add non-hidden _words to the _indexes list
            {
                _indexes.Add(i);
            }
        }

        if (_indexes.Count <= 4) // Check if there are 4 or fewer non-hidden _words
        {
            // Remove all remaining _words
            foreach (int _index in _indexes)
            {
                _words[_index] = "__________";
            }
        }
        else
        {
            int _count = _random.Next(1, 5); // Choose a _random number between 1 and 4 (inclusive)

            for (int i = 0; i < _count; i++)
            {
                // Rest of the code remains the same
                int _randomIndex = _random.Next(0, _indexes.Count);
                int _selectedIndex = _indexes[_randomIndex];

                _words[_selectedIndex] = "__________";
                _indexes.RemoveAt(_randomIndex); // Remove the selected _index from _indexes
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
                return true; // At least one non-hidden _word found
            }
        }

        return false; // No non-hidden _words found
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

