using System;

// Exceeded requirement by add an option under the Load Menu 
// for users to create a backup file for their loaded journal
//Creates an Archive for a Journal file
class Program
{
    static void Main(string[] args)
    {
        int _userChoice = 0;
        Journal _journal = new Journal();
        Entry _myEntries = new Entry();
        Prompt _prompt = new Prompt();

        while (_userChoice != 5)
        {
            _prompt.DisplayMenu();
            Console.Write("What would you like to do? ");
        
            try
            {
                _userChoice = int.Parse(Console.ReadLine());
            }
            catch (Exception message)
            {
                Console.WriteLine(message);
                Console.WriteLine("Choice must be an integer from 1 to 5");
            }
        

            if (_userChoice == 1)
            {
                _journal.WriteJournal();
            }

            else if (_userChoice == 2)
            {
                _journal.DisplayJournal();
            }

            else if (_userChoice == 3)
            {
                _journal.LoadJournal();
            }

            else if (_userChoice == 4)
            {
                _journal.SaveJournal();
            }

        }
    }
}