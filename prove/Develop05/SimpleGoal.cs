using System;

public class SimpleGoal:Goal
{
    private string _goalLogger = "";
    public SimpleGoal()
    {
        SetGoalType("SimpleGoal");
        SetGoalCompleted(false);

    }
    public override string CreateGoal()
    {
        string goalLogger;
        base.CreateGoal();
        _goalLogger = $"{GetGoalType()}:{GetGoalName()},{GetGoalDescription()},{GetGoalPoint()},{GetGoalCompleted()}";
        goalLogger = _goalLogger;
        return goalLogger;
    }
}