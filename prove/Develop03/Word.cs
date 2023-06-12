using System;
using System.Collections.Generic;

class Word
{
    private string _word = string.Empty;
    //private List<string> _wordList = new List<string>();
    int _hiddenWords = 0;
    private string[] _wordList;
    private bool _isHidden = false;

    public string Hide(string word)
    {
        word = new string('_',word.Count());
        return word;
    }

    public bool GetHiddenStatus()
    {
        if(_hiddenWords >= _wordList.Count())
        {
            _isHidden =true;
        }
        return _isHidden;
    }
    public void GetRenderedText()
    {
        int randomCounter = 0;
        
        Random rand = new Random();
        while ((randomCounter < 3) && !(_isHidden))
        {
             int randomer = rand.Next(0,_wordList.Count());//
             string randomWord = _wordList[randomer];
             if (!(randomWord.Contains('_')))
             {
                _wordList[randomer] = Hide(randomWord);
                randomCounter ++;
                _hiddenWords ++;
                GetHiddenStatus();
             }
                
        }

        foreach (string word in _wordList)
        {
            
            Console.Write(word +" ");
            
        }
        Console.WriteLine();
    }

    public void Text (string text)
    {
        _wordList = text.Split(" ");
    }

    public Word(){}
}