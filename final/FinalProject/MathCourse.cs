using System;

public class MathCourse:Course
{

    public MathCourse()
    {
        SetCourseName("Mathematics");
        CreateCourse();
    }
    public MathCourse(string courseName,float score)
    {
        SetCourseName("Mathematics");
        SetCourseScore(score);
    }
    
}