using System;
using System.Collections.Generic;
using System.IO;

class Scripture
{
    private List<string> _scriptList = new List<string>();
    private string _randomScripture = "";
    private string[] _scriptSplit;
    private string _scriptBody;
    private string _scriptHead;
    private string _bookName;
    private int _bookChapter;
    private string _bookNumber;
    private int _startVerse;
    private int _endVerse;
    //private string _filename = "Scripture.txt";
    //splitter();
    public void splitter()
    { 
        _scriptSplit =_randomScripture.Split("~");
        _scriptHead = _scriptSplit[0];
        _scriptBody = _scriptSplit[1];
        _bookName = _scriptHead.Split(" ")[0];
        _bookChapter = int.Parse(_scriptHead.Split(" ")[1].Split(":")[0]);
        _bookNumber = _scriptHead.Split(" ")[1].Split(":")[1];
        _startVerse = int.Parse(_bookNumber.Split("-")[0]);
        _endVerse = 0;
        if (_bookNumber.Contains('-'))
        {
            _endVerse = int.Parse(_bookNumber.Split("-")[1]);
        }
        
    }
    
    public string GetScriptureBody()
    {
        string scriptureBody = _scriptBody;
        return scriptureBody;
    }
    public List<string> scripture(string _filename)
    {
        using (StreamReader file = File.OpenText(_filename))
        {
            string script ="";
            while ((script = file.ReadLine()) != null)
            {
                _scriptList.Add(script);
            }
        }
        return _scriptList;
        
    }
    


    public string GetRandomScripture()
    {
        string randomScripture;
        Random rand = new Random();
        _randomScripture = _scriptList[rand.Next(0,_scriptList.Count() -1)];
        randomScripture = _randomScripture; 
        Console.WriteLine(randomScripture);
        return randomScripture;
    }

    public string CreateScriptureHead()
    {
        Reference _reference = new Reference(_bookName,_bookChapter,_startVerse,_endVerse);
        string scriptureHead =_reference.GetRenderedReference();
        return scriptureHead;
    }    
}