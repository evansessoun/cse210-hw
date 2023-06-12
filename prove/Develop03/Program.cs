// Exceeded requirement by calling scripture from a text file.

using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        string choice ="";
        bool hiddenStatus = false;
        Scripture Scriptures = new Scripture();
        Scriptures.scripture("Scripture.txt");
        string scriptureText = Scriptures.GetRandomScripture();
        Scriptures.splitter();
        string scriptBody = Scriptures.GetScriptureBody();
        string scriptureReference = Scriptures.CreateScriptureHead();
        Word scriptureBody = new Word();
        scriptureBody.Text(scriptBody);

        while((choice != "quit"))
        {
            if(!hiddenStatus)
            {
                Console.WriteLine("Press enter to continue or \'quit\' to finish:");
                choice = Console.ReadLine();
                Console.Clear();
                Console.Write(scriptureReference + " ");
                scriptureBody.GetRenderedText();
                hiddenStatus = scriptureBody.GetHiddenStatus();
            }
            else
            {
                choice = "quit";
            }
        }

    }
}