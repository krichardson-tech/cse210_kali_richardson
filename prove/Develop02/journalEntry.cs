class JournalEntry
{
    public string _date;
    public string _prompt; 
    public string _response;

    public void DisplayJournalEntry()
    {
        Console.WriteLine($"{_date}, {_prompt}");
        Console.WriteLine($"{_response}");
    }

    public void CreateJournalEntry()
    {
        string [] prompts =
        {
            "How was your day?",
            "Talk about someone you met.",
            "What is something unique about today?",
            "How have you helped someone toaday?",
            "What is something you liked about today?",
            "Talk about one thing you'll do better or differently tomorrow.",
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };
        _date = DateTime.Now.ToString();
        Random promptGenerator = new Random();
        int index = promptGenerator.Next(0, prompts.Length); 
        _prompt = prompts[index];
        Console.Write($"{_prompt}: ");
        _response = Console.ReadLine();
    }

}