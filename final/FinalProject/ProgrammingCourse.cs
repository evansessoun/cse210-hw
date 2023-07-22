using System;

public class ProgrammingCourse: Course
{
    float _loadedScore =0.0F;
    private bool _loading = false;
    private float _projectScore = 0;
    private float _totalScore = 0;
    private float _projectPercent = 0.3F;
    private float _coursePercent = 0.7F;
    
    public ProgrammingCourse()
    {
        SetCourseName("Programming");
        CreateCourse();
    }
    public ProgrammingCourse(string Loading, float score)
    {
        SetCourseName("Programming");
        SetCourseScore(score);
        _loading = true;
        _loadedScore =score;
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
        SetCourseScore(_totalScore);
    }

    public float GetTotalScore()
    {
        float totalScore = 0.0F;
        if(_loading)
        {
            _totalScore = _loadedScore;
        }
        else
        {
            totalScore =  _totalScore;
        }
        return totalScore;
    }

}    