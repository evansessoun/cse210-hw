using System;
using System.IO;
using System.Collections.Generic;
public class GoalList
{
    private List<string> _goalList = new List<string>();
    private int _totalPoints = 0;
    private int _point = 0;
    private int _bonus;
    
    public void SetTotalPoints(int totalPoints)
    {
        _totalPoints = totalPoints;
    }

    public int GetTotalPoints()
    {
        int totalPoints = _totalPoints;
        return _totalPoints;
    }
    public void SetGoalList( List<string> goalList)
    {
        _goalList = goalList;
    }
    public void AddGoal(string newGoal)
    {
        _goalList.Add(newGoal);
    }
    public List<string> GetGoalList()
    {
        List<string> goalList ;
        goalList = _goalList;
        return goalList;
    } 
    public void SaveGoalToFile()
    {
        Console.Write("Enter the name of the file to save to: ");
        string fileName = Console.ReadLine();
        using StreamWriter writeGaol = new StreamWriter(fileName);
        writeGaol.WriteLine(_totalPoints);
        foreach(string Goal in _goalList)
        {
            writeGaol.WriteLine(Goal);
        }
    }
    
    public void LoadGoalFromFile()
    {
        Console.Write("Enter the name of the file to load from: ");
        string fileName = Console.ReadLine();
        using (StreamReader readGoals = File.OpenText(fileName))
        {
            string goalText;
            _goalList.Clear();
            while((goalText = readGoals.ReadLine()) != null)
            {
                _goalList.Add(goalText);
            }
        }
        _totalPoints = int.Parse(_goalList[0]);
        _goalList.RemoveAt(0);
    }
    public void DisplayGoalList()
    {
        Console.WriteLine("Total Points: "+_totalPoints);
        Console.WriteLine("");
        Console.WriteLine("The goals are:");
        int count = 1;
        foreach(string goalEntry in _goalList)//.Skip(1))
        {
            string[] entryPart = goalEntry.Split(":");
            string goalType = entryPart[0];
            string goalString = entryPart[1];
            string[] entryStringPart = goalString.Split(",");
            if( goalType == "SimpleGoal")
            {
                if (entryStringPart[3] == "True")
                {
                    Console.WriteLine($"{count}. [X] {entryStringPart[0]} ({entryStringPart[1]})");
                }
                else
                {
                    Console.WriteLine($"{count}. [ ] {entryStringPart[0]} ({entryStringPart[1]})");
                }
            }
            else if(goalType == "EternalGoal")
            {
                Console.WriteLine($"{count}. [ ] {entryStringPart[0]} ({entryStringPart[1]})");
            }
            else
            {
                if((entryStringPart[4]) == (entryStringPart[5]))
                {
                    Console.WriteLine($"{count}. [X] {entryStringPart[0]} ({entryStringPart[1]}) -- Currently completed: {(entryStringPart[5])}/{(entryStringPart[4])}");
                }
                else
                {
                    Console.WriteLine($"{count}. [ ] {entryStringPart[0]} ({entryStringPart[1]}) -- Currently completed: {(entryStringPart[5])}/{(entryStringPart[4])}");
                }
            }
            count ++;
        }
    }
    public void RecordEvent()
    {
        int choice = 0;
        _bonus = 0;
        DisplayGoalList();
        Console.Write("Enter the associated number to record an event: ");
        choice = int.Parse(Console.ReadLine()) -1;
        string events = _goalList[choice];
        string [] eventParts =events.Split(":");
        string eventType = eventParts[0];
        string [] eventBody =  eventParts[1].Split(",");
        if(eventType == "SimpleGoal")
        {
            eventBody[3] = "True";
            _point = int.Parse(eventBody[2]);
            _totalPoints += _point;
            _goalList[choice] = $"{eventType}: {eventBody[0]}, {eventBody[1]}, {eventBody[2]},{eventBody[3]}";
        }
        else if(eventType == "EternalGoal")
        {
            _point = int.Parse(eventBody[2]);
            _totalPoints += _point;
        }
        else if(eventType == "ChecklistGoal")
        {   
            int goalComp = int.Parse(eventBody[5]) + 1;
            eventBody[5] = goalComp.ToString();
            _point = int.Parse(eventBody[2]);
            _totalPoints += _point;
            if((eventBody[4]) == eventBody[5])
            {
                _bonus =int.Parse(eventBody[3]);
                _totalPoints += _bonus;
            }
            _goalList[choice] = $"{eventType}:{eventBody[0]},{eventBody[1]},{eventBody[2]},{eventBody[3]},{eventBody[4]},{eventBody[5]}";
        }
    }
}