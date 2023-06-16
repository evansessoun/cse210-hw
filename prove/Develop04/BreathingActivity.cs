using System;

class Breathing:Activity
{
    private int _breatheInTime = 4;
    private int _breatheOutTime = 6;
    private List<string> _activityList = new List<string>();
    

    public Breathing()
    {
        _activityList.Add("Breath in");
        _activityList.Add("Breath out");
        SetActivityList(_activityList);
        SetActivityName("Breathing Activity");
        SetActivityDescription("This activity will help you relax by walking you through breathing in and out "+
                                "Clear your mind and focus on your breathing");

    }

    public override void StartActivity()
    {
        
        base.StartActivity();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetActivityDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write(_activityList[0] + "...");
            for(int i = _breatheInTime; i >0 ; i--)
            {
                Console.Write( i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine(" ");
            Console.Write(_activityList[1] + "...");
            for(int i = _breatheOutTime; i >0 ; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine("\n");
        }

    }


    
}