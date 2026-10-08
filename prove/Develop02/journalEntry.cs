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
        _date = DateTime.Now.ToString();
        _prompt = "How was your day? "; //come back to later to make a list that will be randomly selected
        Console.Write($"{_prompt}: ");
        _response = Console.ReadLine();
    }

}