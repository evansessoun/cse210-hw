using System;

class Program
{
    static void Main(string[] args)
    {
        bool inSession =true;
        while(inSession)
        {
            int _userChoice = 0;
            Menu menu = new Menu();
            Result result = new Result();
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
                result.AddStudentList(student);

            }
            else if (_userChoice == 2)
            {
                result.ProcessStudentScore();
            }
            else if (_userChoice == 3)
            {
                result.ProcessGeneralScore();
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