using System;
using System.Collections.Generic;

public class Prompt
{
    public List<string> _prompt = new List<string> ();

    public string prompt1 ="What was the happiest moment of your day?";
    public string prompt2 = "What was the worst thing that happened today?";
    public string prompt3 ="What are you grateful for today?";
    public string prompt4 ="What was the strongest emotion I felt today?";
    public string prompt5 ="If I had one thing I could do over today, what would it be?";
    public string prompt6 ="What made you feel sad today?";
    public string prompt7 ="What are some good news you heard today?";
    public string prompt8 ="Who was the most interesting person I interacted with today?";
    
    public string displayPrompt()
    {
        _prompt.Add(prompt1);
        _prompt.Add(prompt2);
        _prompt.Add(prompt3);
        _prompt.Add(prompt4);
        _prompt.Add(prompt5);
        _prompt.Add(prompt6);
        _prompt.Add(prompt7);
        _prompt.Add(prompt8);

        Random randomer = new Random();
        int index = randomer.Next(_prompt.Count);
        string _randomPrompt = _prompt[index];

        return _randomPrompt;
    }

    //public int limit,
    //int limit;
    //limit =  _prompt.Count;
    
    
}