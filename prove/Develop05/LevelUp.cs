using System;

public class LevelUp
{
    private int _goalPoint = 0;
    private string _playerLevel ="";

    public int GetGoalPoint()
    {
        int goalPoint = _goalPoint;
        return goalPoint;
    }
    public void SetGoalPoint(int goalPoint)
    {
        _goalPoint = goalPoint;
    }

    public string GetPlayerLevel()
    {
        SetPlayerLevel();
        string playerLevel =_playerLevel;
        return playerLevel;
    }
    public void SetPlayerLevel()
    {
        if(_goalPoint <= 1500)
        {
            _playerLevel = "Beginner Disciple";
        }
        else if (_goalPoint <= 3000)
        {
            _playerLevel = "Stripling Warrior";
        }
        else if(_goalPoint <= 5000)
        {
            _playerLevel = "Mormon Battalion";
        }
        else
        {
            _playerLevel = "Captain Moroni";
        }
    }

    public void DisplayLevel()
    {
        Console.WriteLine($"Level: {GetPlayerLevel()}");
    }

    public void LevelUpInfo()
    {
        Console.WriteLine($"Your current goal point: {GetGoalPoint()}");
        Console.WriteLine($"Your current Level is {GetPlayerLevel()}");
        Console.WriteLine(" ");
        Console.WriteLine($"You need over 1500 points for Strippling Warrior ");
        Console.WriteLine($"You need over 3000 points for Mormon Battalion ");
        Console.WriteLine($"You need over 5000 points for Captain Moroni ");
    }
}