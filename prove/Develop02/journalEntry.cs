class CreateJournalEntry
{
    public string _date;
    public string _prompt; 
    public string _response;

    public void DisplayJournalEntry()
    {
        Console.WriteLine($"{_date}, {_prompt}");
        Console.WriteLine($"{_response}");
    }
}