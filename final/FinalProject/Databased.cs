using System;
using System.Linq;
using System.Collections.Generic;

public class Databased
{   
    private List<Student> _studentList = new List<Student>();

    public Databased()
    {

    }

    public void Save(List<Student> studentList)
    {
        List<string> studentsData =new List<string>();
        foreach(Student student in studentList)
        {
            string studentInfo ="";
            string studentBio = $"{student.GetStudentName()},{student.GetStudentID()}";
            string courseInfo = String.Empty;
            List<Course> courseList =  student.GetCoursesTaken();
            Course lastCourse = courseList.Last();
            foreach(Course course in courseList)
            {
                if (course == lastCourse)
                {
                    courseInfo += $"{course.GetCourseName()}:{course.GetCourseScore()}";
                }
                else
                {
                     courseInfo += $"{course.GetCourseName()}:{course.GetCourseScore()},";
                }
            }

            studentInfo = studentBio + "~" + courseInfo;
            studentsData.Add(studentInfo);
        }
        Console.Write("Enter the name of the file to save to: ");
        string filename = Console.ReadLine();
        using StreamWriter writeResult = new StreamWriter(filename);
        foreach(string student in studentsData)
        {
            writeResult.WriteLine(student);
        }
    }

    public List<Student> GetStudentList()
    {
        List<Student> studentList = new List<Student>();
        studentList = _studentList;
        return studentList;
    }

    public void Load()
    {
        Console.Write("Enter the name of the file to load from: ");
        string fileName = Console.ReadLine();
        using (StreamReader readResult = File.OpenText(fileName))
        {
            string student;
            _studentList.Clear();
            while((student = readResult.ReadLine()) != null)
            {
                string studentBio = student.Split("~")[0];
                string[] courseInfo = student.Split("~")[1].Split(",");

                Student studentx = new Student();
                studentx.SetStudentName(studentBio.Split(",")[0]);
                studentx.SetStudentID(studentBio.Split(",")[1]);
                foreach(string course in courseInfo)
                {
                    float score = 0.0F;
                    try
                    {
                        score = float.Parse(course.Split(":")[1]);
                    }
                    catch
                    {
                        Console.WriteLine("Error Passing Course Scores");
                    }
                    
                    if(course.Split(":")[0] == "Mathematics")
                    {
                        studentx.AddCourse(new MathCourse("Loading",score));
                    }
                    else if(course.Split(":")[0] == "Science")
                    {
                        studentx.AddCourse(new ScienceCourse("Loading",score));
                    }
                    else if(course.Split(":")[0] == "Programming")
                    {
                        studentx.AddCourse(new ProgrammingCourse("Loading",score));
                    }
                }
                _studentList.Add(studentx);
            }
            
        }

    }
}