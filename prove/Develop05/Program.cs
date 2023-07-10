using System;
// Exceeded requirement by adding a Leveling up feature
// with different titles.
// Users can check their levels and the points they need
//for a higher level in the Menu Option 6. Level Info

class Program
{
    static void Main(string[] args)
    {
        GoalList goalListx = new GoalList();
        //List<string> goalList  = goalListx.GetGoalList();
        int menuChoice = 0;
        while(menuChoice != 7)
        {
            Menu menu = new Menu();
            LevelUp MyLevel = new LevelUp();
            menu.Display();
            menuChoice = menu.SetUserChoice();
            if (menuChoice == 1)
            {
                menu.DisplayGoalOptions();
                int goalOption = menu.SetGoalOption();
                if(goalOption == 1)
                {
                    SimpleGoal simpleGoal = new SimpleGoal();
                    string aSimpleGoal =simpleGoal.CreateGoal();
                    goalListx.AddGoal(aSimpleGoal);
                }
                else if(goalOption == 2)
                {
                    EternalGoal eternalGoal = new EternalGoal();
                    string anEternalGoal = eternalGoal.CreateGoal();
                    goalListx.AddGoal(anEternalGoal);
                }
                else if (goalOption == 3)
                {
                    ChecklistGoal checklistGoal = new ChecklistGoal();
                    string aChecklistGoal = checklistGoal.CreateGoal();
                    goalListx.AddGoal(aChecklistGoal);
                }
                else
                {
                    Console.WriteLine("Enter a valid goal option");
                }
            }
            else if(menuChoice == 2)
            {
                MyLevel.SetGoalPoint(goalListx.GetTotalPoints());
                MyLevel.DisplayLevel();
                goalListx.DisplayGoalList();
                Console.ReadLine();
            }
            else if(menuChoice == 3)
            {
                goalListx.SaveGoalToFile();
            }
            else if(menuChoice == 4)
            {
                goalListx.LoadGoalFromFile();
            }
            else if(menuChoice == 5)
            {
                goalListx.RecordEvent();
            }
            else if(menuChoice == 6)
            {
                MyLevel.SetGoalPoint(goalListx.GetTotalPoints());
                MyLevel.LevelUpInfo();
                Console.ReadLine();
            }
        }
        
    }
}