using System;
using System.Collections.Generic;
using System.IO;
public class Journal
{
    public string _userFile ="";
    string _randomPrompt;
    string _response;
    string _dateTime;
    bool fileLoaded = false;
    bool fileSaving = false;
    Prompt _prompt = new Prompt();
    Entry _entry = new Entry();
    public Journal(){}

    //Displays the journal entries
    public void DisplayJournal()
    {
        foreach ( string entry in _entry._entries)
        {
            string[] parts = entry.Split("~");
            Console.WriteLine($"Date: {parts[0]} - Prompt: {parts[1]} \n{parts[2]}");
        }
    }

    //Saves the journal entries
    public void SaveJournal()
    {
        Console.WriteLine("Enter file name");
        Console.Write(">");
        _userFile = Console.ReadLine();
        fileSaving = true;
        if (!(fileLoaded))
        {
            LoadJournal();
        }
    
        using StreamWriter outputFile = new StreamWriter(_userFile);
        foreach(string entry in _entry._entries)
            {
                outputFile.WriteLine(entry);
            }
        
    }

    //Loading from a journal file
    public void LoadJournal()
    {
        if (!(fileSaving))
        {
            Console.WriteLine("Enter file name");
            Console.Write(">");
            _userFile = Console.ReadLine();
        }
        
        if (fileLoaded)
        {
            _entry._entries.Clear();
        }

        try
        {
            string[] entry = System.IO.File.ReadAllLines(_userFile);
            foreach ( string line in entry)
            {
                _entry._entries.Add(line);
            }
            ArchiveJournal();
        }
        catch (Exception)
        {
            if (!(fileSaving))
            {
                Console.WriteLine("Sorry, your file does not exist");
            }
        }
        fileLoaded = true;
        fileSaving = false;
    }

    //Writing to the journal entry
    public void WriteJournal()
    {
        _randomPrompt = _prompt.DisplayPrompt();
        Console.Write($"{_randomPrompt} \n>");
        _response = Console.ReadLine();
        _dateTime = _entry.DateToString();
        _entry._entries.Add($"{_dateTime}~{_randomPrompt}~{_response}");
    }

    //Creating an Archive for a Journal file
    public void ArchiveJournal()
    {
        Console.Write("Do you want to create a backup for this journal file? \n 1.Yes \n 2. No \n> ");
        int choice = int.Parse(Console.ReadLine());
        if (choice == 1)
        {
            string _userAchive = _userFile.Substring(0,_userFile.Length -4) + "Archive.txt";
            File.Copy(_userFile,_userAchive,true);
        }
    }
}