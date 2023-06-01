public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private string _referenceText;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _referenceText = _reference.GetReferenceText();
        _words = new List<Word>();

        CreateWordInstances(text);
    }

    private void CreateWordInstances(string text)
    {
        string[] wordArray = text.Split(' ');

        foreach (string word in wordArray)
        {
            _words.Add(new Word(word));
        }
    }
    public void HideRandomWords()
    {
        Random random = new Random();

        List<Word> visibleWords = _words.FindAll(word => !word.Hidden());

        if (visibleWords.Count <= 4)
        {
            foreach (Word word in visibleWords)
            {
                word.Hide();
            }
        }
        else
        {
            int count = random.Next(1, 5);

            for (int i = 0; i < count; i++)
            {
                int randomIndex = random.Next(0, visibleWords.Count);
                Word selectedWord = visibleWords[randomIndex];
                selectedWord.Hide();
                visibleWords.RemoveAt(randomIndex);
            }
        }
    }

    public bool HasWordsToHide()
    {
        foreach (Word word in _words)
        {
            if (!word.Hidden())
            {
                return true;
            }
        }

        return false;
    }

    public string GetRenderedText()
    {
        List<string> renderedWords = new List<string>();

        foreach (Word word in _words)
        {
            renderedWords.Add(word.GetWord());
        }

        return string.Join(' ', renderedWords);
    }

    public string GetReferenceText()
    {
        return _referenceText;
    }

    public Word GetWord(int index)
    {
        if (index >= 0 && index < _words.Count)
        {
            return _words[index];
        }

        return null;
    }
}
