using System;

public class ChecklistGoal:Goal
{
    private int _bonusPoint = 0;
    private int _activityNum = 0;
    private int _activityComp = 0;

    public void SetBonusPoint()
    {
        int bonusPoint;
        Console.Write("What is the bonus for accomplishing it that many times? ");
        bonusPoint = int.Parse(Console.ReadLine());
        _bonusPoint = bonusPoint;
    }
    public int GetBonusPoint()
    {
        int bonusPoint = _bonusPoint;
        return bonusPoint;
    }
    public void SetActivityNum()
    {
        int activityNum;
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        activityNum = int.Parse(Console.ReadLine());
        _activityNum = activityNum;
    }
    public int GetActivityNum()
    {
        int activityNum = _activityNum;
        return activityNum;
    }

    public void SetActivityComp(int activityNum)
    {
        _activityNum = activityNum;
    }
    public int GetActivityComp()
    {
        int activityComp = _activityComp;
        return activityComp;
    }


    public ChecklistGoal()
    {
        SetGoalType("ChecklistGoal");
        SetGoalCompleted(false);

    }
    public override string CreateGoal()
    {
        string goalLogger;
        base.CreateGoal();
        SetActivityNum();
        SetBonusPoint();
        goalLogger = $"{GetGoalType()}:{GetGoalName()},{GetGoalDescription()},{GetGoalPoint()},{GetBonusPoint()},{GetActivityNum()},{GetActivityComp()}";
        return goalLogger;

    }
}