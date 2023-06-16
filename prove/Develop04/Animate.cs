using System;

public class Animate
{
    private List<string> _waitingChars = new List<string>();

    public Animate()
    {
        _waitingChars.Add("|");
        _waitingChars.Add("/");
        _waitingChars.Add("-");
        _waitingChars.Add("\\");
        _waitingChars.Add("|");
        _waitingChars.Add("/");
        _waitingChars.Add("-");
        _waitingChars.Add("\\");

    }
    public void Run()
    {
        DateTime Time = DateTime.Now;
        DateTime animateTime = Time.AddSeconds(3);
        while (DateTime.Now < animateTime)
        {
            animator();
        }
        
    }
    public void Run(int seconds)
    {
        DateTime Time = DateTime.Now;
        DateTime animateTime = Time.AddSeconds(seconds);
        while (DateTime.Now < animateTime)
        {
            animator();
        }
    }
    public void animator()
    {
        foreach(string cha in _waitingChars)
            {
                Console.Write(cha);
                Thread.Sleep(200);
                Console.Write("\b \b");
            }
    }
}