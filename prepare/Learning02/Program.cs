using System;

class Program
{
    static void Main(string[] args)
    {
        // Creates an object myResume of the class Resume
        Resume myResume = new Resume();

        // Creates an object job1 of the class Job
        Job job1 = new Job();

        //Assign a value to the _name attribute of myResume
        myResume._name = "Evans Frank Essoun";
        
        // Assign values to the various attributes of the 
        // object job1
        job1._companyName = "SGS Laboratory Services";
        job1._jobTitle = "Lab Technician";
        job1._startYear = 2022;
        job1._endYear = 2023;
        /*job1.DisplayJobDetails();*/

        // Creates an object job2 of the class Job
        Job job2 = new Job();

        // Assign values to the various attributes of the 
        // object job2
        job2._companyName = "Quantum Energy";
        job2._jobTitle = "Service Personel";
        job2._startYear = 2020;
        job2._endYear = 2021;
        /*job2.DisplayJobDetails();*/

        //Populates the List object _jobs in myResume
        //with job1 and job2 objects 
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        /*Console.WriteLine(myResume._jobs[0]._jobTitle);*/

        // Displays the Resume details to the console.
        myResume.DisplayResume();

    }
}