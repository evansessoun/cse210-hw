using System;

public class ProgrammingCourse: Course
{
    private float _projectScore = 0;
    private float _totalScore = 0;
    private float _projectPercent = 0.3F;
    private float _coursePercent = 0.7F;
    
    public ProgrammingCourse()
    {
        SetCourseName("Programming");
        CreateCourse();
    }
    public void SetProjectScore()
    {
        Console.Write("Enter Programming Project Score: ");
        float projectScore = float.Parse(Console.ReadLine());
        _projectScore = projectScore;
    }

    public float GetProjectScore()
    {
        float projectScore = _projectScore;
        return projectScore;
    }

    public override void CreateCourse()
    {
        base.CreateCourse();
        Console.Write("Enter Project Score: ");
        float projectScore = int.Parse(Console.ReadLine());
        _projectScore = projectScore;
        _totalScore = GetCourseScore() * _coursePercent + _projectScore * _projectPercent;
    }

    public float GetTotalScore()
    {
        float totalScore = _totalScore;
        return totalScore;
    }
}