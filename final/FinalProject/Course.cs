using System;

public class Course
{
    private string _courseName = "";
    private float _courseScore = 0.0F;

    public void SetCourseName(string courseName)
    {
        _courseName = courseName;
    }
    public string GetCourseName()
    {
        string courseName = _courseName;
        return courseName;
    }
    public virtual void SetCourseScore()
    {
        Console.Write($"Enter {GetCourseName()} Score: ");
        float courseScore = float.Parse(Console.ReadLine());
        _courseScore = courseScore;
    }
    public void SetCourseScore(float score)
    {
        _courseScore = score;
    }

    public virtual float GetCourseScore()
    {
        float courseScore = _courseScore;
        return courseScore;
    }

    public virtual void CreateCourse()
    {
        SetCourseScore();

    }
}