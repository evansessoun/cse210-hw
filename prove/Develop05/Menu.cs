using System;

public class Menu
{
    private int _userChoice = 0;
    private int _goalOption = 0;
    public void Display()
    {
        Console.Clear();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Create New Goal" +"\n"+
                          "  2. List Goals" +"\n"+
                          "  3. Save Goals" +"\n"+
                          "  4. Load Goals" +"\n"+
                          "  5. Record Event" +"\n"+
                          "  6. Level Info" +"\n"+
                          "  7. Quit");
        Console.Write("Select a choice from the menu: ");
    }

    public int SetUserChoice()
    {
        try
        {
            _userChoice = int.Parse(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("Enter a valid option");
        }
        int userChoice = _userChoice;
        return userChoice;
    }

    public void DisplayGoalOptions()
    {
        Console.WriteLine("\n");
        Console.WriteLine("The types of Goals are:" + "\n" +
                          "  1. Simple Goal" + "\n" +
                          "  2. Eternal Goal" + "\n" +
                          "  3. Checklist Goal" + "\n" +
                          "Which type of goal would you like to create? ");
        
    }
    public int SetGoalOption()
    {
        try
        {
            _goalOption = int.Parse(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("Enter a valid option");
        }
        int goalOption = _goalOption;
        return goalOption;
    }

}