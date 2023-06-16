using System;

class Activity
{
    private string _activityName = "";
    private string _activityDescription = "";
    private int  _activityDuration = 0;
    private string _durationPrompt = "How long, in seconds, would you like for your session?";
    private List<string> _activityList = new List<string>();
    Animate animate = new Animate();

    public void SetActivityName(string activityName)
    {
        _activityName = activityName;
    }
    public void SetActivityDescription(string activityDescription)
    {
        _activityDescription = activityDescription;
    }
    public void SetActivityDuration(int activityDuration)
    {
        _activityDuration = activityDuration;
    }

    public void SetActivityList(List<string> activityList)
    {
        _activityList = activityList;
    }

    public string GetAcivityName()
    {
        return _activityName;
    }
    public string GetActivityDescription()
    {
        return _activityDescription;
    }
    public int GetActivityDuration()
    {
        return _activityDuration;
    }

    public List<string> GetActivityList()
    {
        return _activityList;
    }
    public void GetDurationPrompt()
    {
        Console.Write(_durationPrompt);
    }
    public void DisplayMenu()
    {
        Console.Clear();
        Console.WriteLine("Menu Options");
        Console.WriteLine("1.   Breathing Activity");
        Console.WriteLine("2.   Reflection Activity");
        Console.WriteLine("3.   Listing Activity");
        Console.WriteLine("4.   Quit");
        Console.WriteLine("Select a choice from the menu: ");
    }

    public void DisplayWelcomeMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName}");
        Console.WriteLine(" ");
    }

    public void DisplayActDescription()
    {
        Console.WriteLine(_activityDescription);
        Console.WriteLine(" ");
    }

    public string PickRandomMessage()
    {
        Random rand = new Random();
        string randomMessage =_activityList[rand.Next(0,_activityList.Count())];
        return randomMessage;
    }

    public void GetReady()
    {
        Console.Clear();
        Console.WriteLine("Get ready...\n");
        animate.Run();
        
    }

    public virtual void StartActivity()
    {
        DisplayWelcomeMessage();
        DisplayActDescription();

        GetDurationPrompt();
        SetActivityDuration(int.Parse(Console.ReadLine()));
        GetReady();
        
    }

    public void EndActivity()
    {
        Console.WriteLine("Well done!!");
        animate.Run();
        Console.WriteLine(" ");
        Console.WriteLine($"You have completed another {_activityDuration} seconds of {_activityName}");
        animate.Run();

    }
}