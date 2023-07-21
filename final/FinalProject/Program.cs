using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        Result result = new Result();
        List<Student> _studentList = new List<Student>();
        bool inSession =true;
        while(inSession)
        {
            int _userChoice = 0;
            
            //Course course  = new Course();
            //ScienceCourse scienceCourse = new ScienceCourse();
            //ProgrammingCourse programmingCourse  = new ProgrammingCourse();
            //MathCourse mathCourse = new MathCourse();
            

            menu.DisplayMenu();

            try
            {
                _userChoice = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Enter a Valid option");
            }

            if (_userChoice == 1)
            {
                Student student = new Student();
                student.CreateDetails();
                _studentList.Add(student);

            }
            else if (_userChoice == 2)
            {
                result.ProcessStudentScore(_studentList);
                ///
                foreach (Student student in result.GetStudentList())
                {
                    Console.WriteLine(student.GetStudentName());
                    foreach(float score in student.GetStudentScore())
                    {
                        Console.WriteLine(score);
                    }
                }
            }
            else if (_userChoice == 3)
            {
                result.ProcessGeneralScore(_studentList);
            }
            else if (_userChoice == 4)
            {
                
            }
            else if (_userChoice == 5)
            {
                inSession = false;
            }
            else
            {
                Console.WriteLine("Choose a valid option");
            }
        }
    }
}