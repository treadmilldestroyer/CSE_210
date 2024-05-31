using System;
class Scripture
{
    private Reference _reference; 
    private List<Word> _words;

// The order of the parameters needed to be arranged to have the optional parameter at the end and it made sense to keep the rest of the reference parameters together so that is why the text of the scripture parameter is first.
    public Scripture(string text, string book, int chapter, int verse, int? endVerse = null) 
    {
        _reference = new Reference(book, chapter, verse, endVerse);
        _words = new List<Word>(); // Create a en empty list where the separated words from the text string will be added into. 

        string[] splitText = text.Split(' ');
        foreach (string word in splitText)
        {
            _words.Add(new Word(word));
        }
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
        
        Random random = new Random();

        if (visibleWords.Count == 1)
        {
            visibleWords[0].Hide();
            return true;
        }
        int randomIndex1 = random.Next(visibleWords.Count);
        visibleWords[randomIndex1].Hide();

        if(visibleWords.Count > 1)
        {
            int randomIndex2;
            do
            {
                randomIndex2 = random.Next(visibleWords.Count);
            }
            while (randomIndex2 == randomIndex1);
            visibleWords[randomIndex2].Hide();

            int randomIndex3;
            do
            {
                randomIndex3 = random.Next(visibleWords.Count);
            } 
            while (randomIndex3 == randomIndex1 || randomIndex3 == randomIndex2);
            visibleWords[randomIndex3].Hide();
        }
        return true;
    }
}