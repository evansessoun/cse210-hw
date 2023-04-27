using System;

class Program
{
    static void Main(string[] args)
    {
        string choice = "yes";
        do
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1,100);
            Console.Write("Guess the magic number from 1 to 100: ");
            int guessNumber;
            int counter = 1;

            do{
                guessNumber = int.Parse(Console.ReadLine());
                if (guessNumber == number)
                {
                    Console.WriteLine($"You guessed it  Guesses: {counter}");

                }
                else if(guessNumber < number)
                {
                    Console.WriteLine("Lower");
                }
                else {
                    Console.WriteLine("Higher");
                }
                counter ++;
            } while (!(guessNumber == number));
            Console.Write("Do you want to play again (yes/no): ");
            choice = Console.ReadLine();
        } while (choice == "yes");
        
    }
}