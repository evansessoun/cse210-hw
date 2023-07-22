using System;

public class Result
{
    private List<Student> _studentList = new List<Student>();
    private List<Course> _courseList = new List<Course>();
    private List<float> _courseScores = new List<float>();
    private float _courseMaxScore = 0.0F;
    private float _courseMinScore = 0.0F;
    private float _courseAvgScore = 0.0F;
    private string _studentName ="";

    public List<Student> GetStudentList()
    {
        List<Student> studentList = _studentList;
        return studentList;
    }
    
    public void CalcAvgScore(List<float> courseScore)
    {   
        _courseScores =courseScore;
        int count = 0;
        float totalScore = 0;
        foreach(float score in _courseScores)
        {
            totalScore += score;
            count ++;
        }
        _courseAvgScore = totalScore/count;
    }
    public float GetAvgScore()
    {

        float avgScore = _courseAvgScore;
        return avgScore;
    }
    public void CalcMinScore(List<float> scores)
    {
        _courseScores = scores;
        float minScore =1000.0F;
        foreach(float score in _courseScores)
        {
            if(score < minScore)
            {
                minScore = score;
            }
        }
        _courseMinScore = minScore;
    }
    public void CalcMaxScore(List<float> scores)
    {
        _courseScores = scores;
        float maxScore =0.0F;
        foreach(float score in _courseScores)
        {
            if(score > maxScore)
            {
                maxScore = score;
            }
        }
        _courseMaxScore = maxScore;
    }
    public float GetMaxScore()
    {
        float maxScore = _courseMaxScore;
        return maxScore;
    }

    public float GetMinScore()
    {
        float minScore = _courseMinScore;
        return minScore;
    }

    public void AddCourseList(Course course)
    {
        _courseList.Add(course);

    }
    public void AddStudentList(Student student)
    {
        _studentList.Add(student);
        foreach(Course course in student.GetCoursesTaken())
        {
            AddCourseList(course);
        }
    }

    public Result()
    {

    }

    public void ProcessStudentScore(List<Student> studentLists)
    {
        List<Student> studentList = studentLists;
        foreach(Student student in studentList)
        {
            _studentName = student.GetStudentName();
            List<Course> coursesTaken = student.GetCoursesTaken();
            List<float> scores  = new List<float>();
            Console.WriteLine(" ");
            Console.WriteLine($"Result for {_studentName}:");
            Console.WriteLine($"Number of courses enrolled: {coursesTaken.Count()}");
            Console.WriteLine($"Course Name:        Course Score");

            foreach(Course course in  coursesTaken)
            {
                string courseName = course.GetCourseName();
                float courseScore = course.GetCourseScore();
                scores.Add(courseScore);
                int dot =courseName.Length;
                string space = new String(' ', 19 - dot);
                Console.WriteLine($"{courseName}:{space}{courseScore}");
            }
            
            CalcAvgScore(scores);
            CalcMaxScore(scores);
            CalcMinScore(scores);
            Console.WriteLine($"Highest Score: {_courseMaxScore}");
            Console.WriteLine($"Lowest Score: {_courseMinScore}");
            Console.WriteLine($"Average Score: {_courseAvgScore}");
            Console.WriteLine(" ");

            
        }
    }    

    public void ProcessGeneralScore(List<Student> studentList)
    {
        List<float> mathScores = new List<float>();
        List<float> scienceScores = new List<float>();
        List<float> programmingScores = new List<float>();
        List<List<float>> courseList = new List<List<float>>();
        List<Course> courses = new List<Course>();
        foreach(Student student in studentList)
        {
            courses = student.GetCoursesTaken();
            foreach(Course course in courses)
            {
                if(course.GetCourseName() == "Mathematics")
                {
                    mathScores.Add(course.GetCourseScore());
                }
                else if(course.GetCourseName() == "Science")
                {
                    scienceScores.Add(course.GetCourseScore());
                }
                else if(course.GetCourseName() == "Programming")
                {
                    programmingScores.Add(course.GetCourseScore());
                }
            }
        }
        courseList.Add(mathScores);
        courseList.Add(scienceScores);
        courseList.Add(programmingScores);
        
        int counter = 0;
        foreach(List<float> scores in courseList)
        {
            counter ++;
            CalcAvgScore(scores);
            CalcMaxScore(scores);
            CalcMinScore(scores);
            string courseName ="";
            if(counter == 1)
            {
                courseName = "Mathematics";
            }
            else if(counter == 2)
            {
                courseName = "Science";
            }
            else if(counter == 3)
            {
                courseName = "Programming";
            }
            Console.WriteLine(" ");
            Console.WriteLine($"General Result for {courseName}:");
            Console.WriteLine($"Number of students enrolled: {_courseScores.Count()}");
            Console.WriteLine($"Highest Score: {_courseMaxScore}");
            Console.WriteLine($"Lowest Score: {_courseMinScore}");
            Console.WriteLine($"Average Score: {_courseAvgScore}");
            Console.WriteLine(" ");

        }
    }
}