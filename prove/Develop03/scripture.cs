class Scripture
{
    private List<Word> _words;
    private ScriptureReference _reference;

    public Scripture(string bookName, int chapter, int verse, string text) // constructor
    {
        _words = ConvertToWordList(text);
        // _words[7].Hide(); // test

        _reference = new ScriptureReference(bookName, chapter, verse);
    }

    public Scripture(string bookName, int chapter, int startVerse, int endVerse, string text) // constructor
    {
        _words = ConvertToWordList(text);
        _reference = new ScriptureReference(bookName, chapter, startVerse, endVerse);
    }

    public void showScripture() //method
    {
        Console.WriteLine(_reference.getScriptureReference());

        foreach(Word word in _words)
        {
            word.Display();
        }
    }

    /*****************************************************
    * ConvertToWordList() - this method will recive a string parameter, which is a paragraph of text. it will split that text into words and add those words to a List<Word> and return the list
    *****************************************************/

    private List<Word> ConvertToWordList(string text)
    {
        List<Word> tempWordList = new List<Word>();
        string[] tempWords = text.Split(' '); // sepertates the scripture reference by their words via spliting spaces thus creating an array of words

        foreach(string w in tempWords)
        {
            Word tempWord = new Word(w);
            tempWordList.Add(tempWord);
        }

        return tempWordList;
    }
}