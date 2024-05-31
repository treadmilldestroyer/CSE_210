using System;
class Word
{
    private string _scriptureText;
    private bool _hidden;

    public Word(string scriptureText)
    {
        _scriptureText = scriptureText;
        _hidden = false;
    }

// This function makes _hidden true which will activate the hiding of the word.
    public void Hide()
    {
        _hidden = true;
    }

// This function gets the scripture text.
    public string GetScriptureText()
    {
        return _scriptureText;
    }
  
//   This function tells the state of _hidden in each word.
    public bool Hidden()
    {
        return _hidden;
    }
}