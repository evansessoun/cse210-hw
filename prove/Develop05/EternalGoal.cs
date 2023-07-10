using System;

public class EternalGoal:Goal
{
    private string _goalLogger = "";
    public EternalGoal()
    {
        
        SetGoalType("EternalGoal");
        SetGoalCompleted(false);

    }
    public override string CreateGoal()
    {
        string goalLogger;
        base.CreateGoal();
        _goalLogger = $"{GetGoalType()}:{GetGoalName()},{GetGoalDescription()},{GetGoalPoint()}";
        goalLogger = _goalLogger;
        return goalLogger;
    }
}