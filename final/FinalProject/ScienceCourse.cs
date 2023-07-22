using System;

public class ScienceCourse: Course
{
    private float _loadedScore = 0.0F;
    private bool _loading = false;
    private float _labScore = 0;
    private float _totalScore = 0;
    private float _labPercent = 0.3F;
    private float _coursePercent = 0.7F;
    
    public ScienceCourse()
    {
        SetCourseName("Science");
        CreateCourse();
    }
    public ScienceCourse(string Loading, float score)
    {
        SetCourseName("Science");
        SetCourseScore(score);
        _loading = true;
        _loadedScore = score;
    }

    public float GetLabScore()
    {
        float labScore = _labScore;
        return labScore;
    }

    public override void CreateCourse()
    {
        base.CreateCourse();
        Console.Write("Enter Lab Score: ");
        float labScore = int.Parse(Console.ReadLine());
        _labScore = labScore;
        _totalScore = GetCourseScore() * _coursePercent + _labScore * _labPercent;
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