using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int> ();
        int newNumber;
        double average;
        int maxNumber;
        int smallNumber = 1000000000;
        do{
            Console.Write("Enter a number: ");
            newNumber = int.Parse(Console.ReadLine());
            if (!(newNumber == 0))
            {
                numbers.Add(newNumber);
            }
        }while (!(newNumber == 0));

        double sum = 0;
        foreach(int number in  numbers)
        {
            sum = sum + number;
            if ((number < smallNumber) && (number > 0))
            {
                smallNumber = number;
            }
        }
        int numberCount = numbers.Count;
        average = sum/numberCount;
        maxNumber = numbers.Max();
        numbers.Sort();

        
        Console.WriteLine($"Sum of the Numbers: {sum}");
        Console.WriteLine($"Average: {average}");
        Console.WriteLine($"The largest number is {maxNumber}");
        Console.WriteLine($"The smallest positive number is: {smallNumber}");

        foreach (int sorted in numbers)
        {
            Console.WriteLine(sorted);
        }
    }
}