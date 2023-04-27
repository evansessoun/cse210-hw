using System;

class Program
{
    static void Main(string[] args)
    {
        // Calls the DisplayWelcome function and displays the welcome message
        DisplayWelcome();

        // Calls the PromptUserName function and assigns the return string value 
        // to the variable userName
        string userName = PromptUserName();

        // Calls the PromptUserNumber function and assigns the return integer value 
        // to the variable userNumber
        int userNumber = PromptUserNumber();

        // Calls SquareNumber function with the argument userNumber and assigns  
        // the return integer value to the variable squaredNumber
        int squaredNumber = SquareNumber(userNumber);

        //Calls DisplayResult function using the userName and squareNumber as 
        // arguments and displays to the console.
        DisplayResult(userName, squaredNumber);

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program");
        }

        static string  PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int userNumber = int.Parse(Console.ReadLine());
            return userNumber;
        }

        static int SquareNumber(int number)
        {
            int squared = number * number;
            return squared;
        }

        static void DisplayResult(string userName, int squaredNumber)
        {
            Console.WriteLine($"{userName}, the square of your number is {squaredNumber}");
        }
    }
}