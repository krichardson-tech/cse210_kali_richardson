using System.Reflection.Metadata.Ecma335;

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

    public void HideRandomWords()
    {
        Random randomGenerator = new Random();  
        int number = randomGenerator.Next(_words.Count);
        _words[number].Hide();
        int number2 = randomGenerator.Next(_words.Count);
        _words[number2].Hide();
        int number3 = randomGenerator.Next(_words.Count);
        _words[number3].Hide();
        int number4 = randomGenerator.Next(_words.Count);
        _words[number4].Hide();

        // ~~~~~~~~BELOW would have also worked as well~~~~~~~~
        // for (int i = 0; i < 4; i++)
        // {
        //     int number = randomGenerator.Next(_words.Count);
        //     _words[number].Hide();
        // }
    }

    public bool CheckAllWordsHidden()
    {
        foreach(Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        
        return true;
    }

    public void DisplayScripture() //method
    {
        Console.WriteLine(_reference.GetScriptureReference());

        foreach(Word word in _words)
        {
            word.Display();
        }
    }


}