using System;

public class Goal
{
    private string _goalType = "";
    private string _goalName = "";
    private string _goalDescription ="";
    private int _goalPoint = 0;
    private bool _goalCompleted;

    public void SetGoalName()
    {
        string goalName;
        Console.Write("What is the name of your goal? ");
        goalName = Console.ReadLine();
        _goalName = goalName;
    }
    public string GetGoalName()
    {
        return _goalName;
    }
    public void SetGoalDescription()
    {
        string goalDescription;
        Console.Write("What is a short description of it? ");
        goalDescription = Console.ReadLine();
        _goalDescription =  goalDescription;
    }
    public string GetGoalDescription()
    {
        return _goalDescription;
    }
    public void SetGoalPoint()
    {
        int goalPoint;
        Console.Write("What is the amount of points associated with this goal? ");
        goalPoint = int.Parse(Console.ReadLine());
        _goalPoint = goalPoint;
    }
    public int GetGoalPoint()
    {
        return _goalPoint;
    }
    public string GetGoalType()
    {
        string goalType = _goalType;
        return goalType;
    }
    public void SetGoalType(string goalType)
    {
        _goalType = goalType;
    }
    public bool GetGoalCompleted()
    {
        bool status;
        status = _goalCompleted ;
        return status;
    }
    public void SetGoalCompleted(bool status)
    {
        _goalCompleted = status;
    }
    public void IsCompleted()
    {
        _goalCompleted = true;
    }

    public virtual string CreateGoal()
    {
        string goalLogger="";
        SetGoalName();
        SetGoalDescription();
        SetGoalPoint();
        return goalLogger;
        
    }
}