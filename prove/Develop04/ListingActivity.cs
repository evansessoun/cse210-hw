using System;

class ListingActivity: Activity
{
    private List<string> _activityList = new List<string>();
    private List<int> _randomActLog = new List<int>();
    private List<string> _questionAnswers = new List<string>();
    Animate animate = new Animate();

    public ListingActivity()
    {
        _activityList.Add("Who are people that you appreciate?");
        _activityList.Add("What are personal strengths of your?");
        _activityList.Add("Who are people that you have helped this week?");
        _activityList.Add("When have you felt the Holy Ghost this month?");
        _activityList.Add("Who are some of your personal heroes?");

        SetActivityList(_activityList);
        SetActivityName("List Activity");
        SetActivityDescription("This activity will help you reflect on the goood things in life "+
                                "by having you list as you can in a certain area");
        
    }

    class QuesAnswer
    {
        private string _question = "";
        private List<string> _responses = new List<string>();
        public void AddQuestion(string question)
        {
            _question = question;
        }

        public void AddResponse(string response)
        {
            _responses.Add(response);
        }
    }

    public override void StartActivity()
    {
        base.StartActivity();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetActivityDuration());
        Random rand = new Random();

        while (DateTime.Now < endTime)
        {
            bool notFoundPrompt = true;
            int randomPromptNumb = 0;
            string randQuestion ="";
            List<string> quesResponse = new List<string>();
            while (notFoundPrompt)
            {
                if (_randomActLog.Count() == _activityList.Count())
                {
                    _randomActLog.Clear();
                }
                int randomer = rand.Next(0,_activityList.Count());
                if (!(_randomActLog.Contains(randomer)))
                {
                    randomPromptNumb = randomer;
                    _randomActLog.Add(randomer);
                    randQuestion = _activityList[randomPromptNumb];
                    Console.WriteLine(randQuestion);
                    animate.Run(5);
                    notFoundPrompt = false;
                }
                else
                {
                    notFoundPrompt = true;
                }
            }
            animate.Run(5);

            DateTime startListing = DateTime.Now;
            DateTime endListing = startListing.AddSeconds(15);
            while (DateTime.Now < endListing)
            {
                quesResponse.Add(Console.ReadLine());
            }

            string archiveQuestion = randQuestion + "~";
            foreach (string response in quesResponse)
            {
                archiveQuestion += response + ", ";
            }
            _questionAnswers.Add(archiveQuestion);
        }
        using StreamWriter outputFile = new StreamWriter("ListingActivity.txt");
        foreach(string ListActivity in _questionAnswers)
        {
            outputFile.WriteLine(ListActivity);
        }
    }
}