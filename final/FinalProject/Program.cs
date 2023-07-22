using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        Result result = new Result();
        List<Student> _studentList = new List<Student>();
        Databased database = new Databased();
        bool inSession =true;
        while(inSession)
        {
            int _userChoice = 0;

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
            }
            else if (_userChoice == 3)
            {
                result.ProcessGeneralScore(_studentList);
            }
            else if (_userChoice == 4)
            {
                database.Save(_studentList);
            }
            else if (_userChoice == 5)
            {
                database.Load();
                _studentList = database.GetStudentList();
            }
            else if (_userChoice == 6)
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