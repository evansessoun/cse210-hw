using System;

class Program
{
    static void Main(string[] args)
    {
        /* Receives user's first name and stores it in a variable firstName*/
        Console.Write("What is your First Namu? ");
        string firstName = Console.ReadLine();

        /* Receives user's last name and stores it in a variable lastName*/
        Console.Write("What is your Last Name? ");
        string lastName = Console.ReadLine();

        /* Display an empty spacing followed by user's last name , full name. */
        Console.WriteLine("");
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
        
    }
}