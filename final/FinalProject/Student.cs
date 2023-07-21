using System;

public class Student
{
    private string _studentName = "";
    private string _studentID = "";
    private List<Course> _coursesTaken = new List<Course>();
    private List<float> _courseScores = new List<float>();
    private int _numCoursesTaken = 0;
    //Course course = new Course();

    public string GetStudentName()
    {
        string studentName = _studentName;
        return studentName;
    }

    public int GetNumCoursesTaken()
    {
        int numCoursesTaken = _numCoursesTaken;
        return numCoursesTaken;
    }

    public void SetStudentName()
    {
        Console.WriteLine("Student Name: ");
        string studentName = Console.ReadLine();
        _studentName = studentName;
    }

    public string GetStudentID()
    {
        string studentID = _studentID;
        return studentID;
    }

    public List<float> GetStudentScore()
    {
        List<float> studentScores = _courseScores;
        return studentScores;
    }
    public void SetStudentID()
    {
        Console.WriteLine("Student ID: ");
        string studentID = Console.ReadLine();
        _studentID = studentID;
    }
    public void AddCourse(Course course)
    {
        _coursesTaken.Add(course);
        _numCoursesTaken ++;
        _courseScores.Add(course.GetCourseScore());
       
    }

    public List<Course> GetCoursesTaken()
    {
        List<Course> coursesTaken = _coursesTaken;
        return coursesTaken;
    }

    public void CreateDetails()
    {
        Console.WriteLine(" ");
        SetStudentName();
        SetStudentID();
        bool addCourse = true;
        List<string> choices = new List<string>();
        
        while (addCourse)
        {
            Console.WriteLine(" ");
            Console.WriteLine("Add Course Info"+"\n"+
                          "1. Mathematics"+"\n"+
                          "2. Science" +"\n"+
                          "3. Programming"+"\n"+
                          "4. Exit");
            Console.Write("Select an option:");
            string choice = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("All Scores are out of 100%");
            Console.WriteLine("");
            
            if (choice == "1")
            {
                if(!(choices.Contains(choice)))
                {
                    AddCourse(new MathCourse());
                    choices.Add(choice);
                }
                else
                {
                    Console.WriteLine("Mathematics Already Added");
                }
                
            }
            else if (choice == "2")
            {
                if(!(choices.Contains(choice)))
                {
                    AddCourse(new ScienceCourse());
                    choices.Add(choice);
                }
                else
                {
                    Console.WriteLine("Science Already Added");
                }
            }
            else if (choice == "3")
            {
                if(!(choices.Contains(choice)))
                {
                    AddCourse(new ProgrammingCourse());
                    choices.Add(choice);
                }
                else
                {
                    Console.WriteLine("Programming Already Added");
                }
            }
            else if (choice == "4")
            {
                addCourse = false;
            }
            else
            {
                Console.WriteLine("Select a valid option");
            }
            
        }

    }
}