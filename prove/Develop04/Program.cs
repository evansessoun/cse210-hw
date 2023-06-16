using System;
using System.IO;

// Ensured that random prompt or question does not repeat
// until all other questions in the list have been exhausted
class Program
{
    static void Main(string[] args)
    {
        //long myDate = DateTime.Now.ToFileTime();
        
        int userChoice = 0;
        while(userChoice != 4)
        {
            Activity activity = new Activity();
            activity.DisplayMenu();
            try
            {
                userChoice = int.Parse (Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Select a valid option (1 - 4)");
            }
            
            if (userChoice == 1)
            {
                Breathing Breathe = new Breathing();
                Breathe.StartActivity();
                Breathe.EndActivity();
            }
            else if (userChoice == 2)
            {
                ReflectionActivity Reflection = new ReflectionActivity();
                Reflection.StartActivity();
                Reflection.EndActivity();
            }
            else if (userChoice ==3)
            {
                ListingActivity Listing = new ListingActivity();
                Listing.StartActivity();
                Listing.EndActivity();
            }
            else if (userChoice ==4){}
            else
            {
                Console.WriteLine("Select a valid option (1 - 4)");
            }

        }
    }
}