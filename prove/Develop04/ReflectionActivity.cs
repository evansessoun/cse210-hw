using System;

class ReflectionActivity : Activity
{
    private List<string> _activityList = new List<string>();
    private List<string> _promptQuestions = new List<string>();
    private List<int> _randomActLog = new List<int>();
    private List<int> _randomQuestionLog = new List<int>();
    Animate animate = new Animate();
    public ReflectionActivity()
    {
        _activityList.Add("Think of a time when you stood up for someone else");
        _activityList.Add("Think of a time when you did something really difficult");
        _activityList.Add("Think of a time when you helped someone in need");
        _activityList.Add("Think of a time when you did something truly selfless");
        
        _promptQuestions.Add("Why was this experience meaningful to you?");
        _promptQuestions.Add("Have you ever done anything like this before?");
        _promptQuestions.Add("How did you get started?");
        _promptQuestions.Add("How did you feel when it was complete?");
        _promptQuestions.Add("What made this time different than other times when you were not as successful?");
        _promptQuestions.Add("What is your favorite thing about this experience?");
        _promptQuestions.Add("What could you learn from this experience that applies to other situations?");
        _promptQuestions.Add("What did you learn about yourself through this experience?");
        _promptQuestions.Add("How can you keep this experience in mind in the future?");

        SetActivityList(_activityList);
        SetActivityName("Reflection Activity");
        SetActivityDescription("This activity will help you reflect on times in your life when" +
                                " you have shown strenght and resilience. This will help you" + 
                                " recognize the power you have and you can use it in other aspect of your life");
        
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
            bool notFoundMessage = true;
            int randomPromptNumb = 0;
            int randomMessageNumb = 0;
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
                    Console.WriteLine(_activityList[randomPromptNumb]);
                    animate.Run(5);
                    notFoundPrompt = false;
                }
                else
                {
                    notFoundPrompt = true;
                }
            }
            
            Console.WriteLine(" ");
            while (notFoundMessage)
            {
                if (_randomQuestionLog.Count() == _activityList.Count())
                {
                    _randomQuestionLog.Clear();
                }
                int randomer = rand.Next(0,_promptQuestions.Count());
                if (!(_randomQuestionLog.Contains(randomer)))
                {
                    randomMessageNumb = randomer;
                    _randomQuestionLog.Add(randomer);
                     Console.WriteLine(_promptQuestions[randomMessageNumb]);
                    animate.Run(5);
                    notFoundMessage = false;
                }
            }
            Console.WriteLine(" ");
            
        }
    }
}