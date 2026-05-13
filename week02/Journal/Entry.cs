using System.Security.Cryptography.X509Certificates;

public class JournalEntry()
{
    //Data
    public string _entry;
    public string _prompt;
    //prompt list(add more for actual program)(current test)
    private List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What was the most challenging bug you squashed today?",
        "Describe a piece of code you wrote today that you are proud of.",
        "What C# feature or NuGet package did you experiment with today?",
        "If you could refactor one method you wrote this week, which one and why?",
        "What did you learn from your latest compiler error or failed test?",
        "How did you balance code readability versus performance today?",
        "What is your primary development goal for tomorrow morning?",
        "What is your main intention or priority for today?",
        "What brought you the most joy or peace today?",
        "How does your body feel right now?",
        "What drained your energy today, and what restored it?",
        "What are three small things you are thankful for right now?",
        "What choice did you make today that aligned with your values?",
        "In what ways are you different now compared to one year ago?",
        "What is something you are avoiding thinking about?",
        "What is a quality you admire most about yourself?",
        "What negative self-talk did you catch yourself saying today?",
        "What is worrying you right now, and can you control it?",
        "What specifically triggered your frustration today?",
        "What is a recent victory you have not given yourself credit for?",
        "Who do you need to forgive right now, even if it is yourself?",
        "When did your mood shift today, and what caused it?",
        "What does your ideal ordinary day look like five years from now?",
        "What is one small daily habit you want to build or break?",
        "What is an experience you want to have before this year ends?",
        "What does your perfect workspace or living space look like?",
        "What advice would your future, wiser self give you today?",
        "What career would you pursue in an alternate universe?",
        "Describe your favorite room using all five senses.",
        "If time and money were limitless, how would you spend tomorrow?",
        "What book, movie, or song recently changed how you think?"
    };
    // creates new entry with a random prompt for each entry
    public void CreateNewEntry()
    {
        //ranom prompt for entry
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        _prompt =_prompts[index];

        //prompt user and record response
        Console.WriteLine(_prompt);
        _entry = Console.ReadLine();
    }

}