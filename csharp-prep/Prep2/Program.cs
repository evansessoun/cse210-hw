using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your percentage score? ");
        int score = int.Parse(Console.ReadLine());
        
        string Letter ;
        Letter = "";

        string gradeSign;
        gradeSign = "";
        if (score % 10 >= 7 &&  score < 90 && score >= 60)
        {
            gradeSign = "+";
        }
        else if (score % 10 <= 3  && score >= 60 )
        {
            gradeSign = "-";
        }

        if (score >= 90)
        {
            Letter = "A";
            
        }
        else if (score >= 80)
        {
            Letter = "B";
        }
        else if (score >= 70)
        {
            Letter = "C";
        }
        else if (score >= 60)
        {
            Letter = "D";
        }
        else
        {
            Letter = "F";
        }

        Console.WriteLine($"Your grade is {Letter}{gradeSign}.");
    }
}