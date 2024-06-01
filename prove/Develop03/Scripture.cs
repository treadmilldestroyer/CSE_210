using System;
class Scripture
{
    private Reference _reference; 
    private List<Word> _words;
    private Stack<List<Word>> _history;

// The order of the parameters needed to be arranged to have the optional parameter at the end and it made sense to keep the rest of the reference parameters together so that is why the text of the scripture parameter is first.
    public Scripture(string text, string book, int chapter, int verse, int? endVerse = null) 
    {
        _reference = new Reference(book, chapter, verse, endVerse);
        _words = new List<Word>(); // Create a en empty list where the separated words from the text string will be added into.
        _history = new Stack<List<Word>>(); 

        string[] splitText = text.Split(' ');
        foreach (string word in splitText)
        {
            _words.Add(new Word(word));
        }
        _history.Push(new List<Word>(_words));
    }

// This function is doing the majority of the work for this program. It actually displays the scripture reference and then the scripture. This function will be called over and over as more words are taken each time.
    public void DisplayScriptureAndReference()
    {
        Console.WriteLine($"{_reference}");
        foreach (Word word in _words)
        {
            if (word.Hidden())
            { 
                Console.Write(new string('_', word.GetScriptureText().Length) + " ");
            }
            else
            {
                Console.Write(word.GetScriptureText() + " ");
            }
        }
    }

       public void DisplayRevertedData()
    {
        Console.WriteLine($"{_reference}");
        foreach (List<Word> wordList in _history)
        {
            foreach (Word word in wordList)
            {
                if (word.Hidden())
                { 
                    Console.Write(new string('_', word.GetScriptureText().Length) + " ");
                }
                else
                {
                    Console.Write(word.GetScriptureText() + " ");
                }
            }
        }
    }

// This function adds the words that are not (!) hidden to a list. 
    private List<Word> GetVisibleWords()
    {
        List<Word> visibleWords = new List<Word>();
        foreach (Word word in _words)
        {
            if (!word.Hidden())
                visibleWords.Add(word);
        }
        return visibleWords;
    }

// This function allows the program to hide three words at a time. And if at the end there are less than three, it will still remove the remaining one or two words.
    public bool HideRandomWord()
    {
        List<Word> visibleWords = GetVisibleWords();
        if (visibleWords.Count == 0)
            return false;
        DisplayScriptureAndReference();
        _history.Push(new List<Word>(_words));
        Console.WriteLine(_history);
        
        Random random = new Random();

        int wordsToHide = Math.Min(3, visibleWords.Count);
        for (int i = 0; i < wordsToHide; i++)
        {
            int randomIndex = random.Next(visibleWords.Count);
            visibleWords[randomIndex].Hide();
            visibleWords.RemoveAt(randomIndex);
        }
        DisplayScriptureAndReference();
        return true;
    }

    public void RevertToPrevState()
    {
        if (_history.Count > 0)
        {
            _words = _history.Pop();
            Console.WriteLine("Reverted to previous state.");
            DisplayRevertedData();
        }
        else
        {
            Console.WriteLine("Nothing to revert.");
        }
    }
}