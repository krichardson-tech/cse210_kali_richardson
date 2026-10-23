using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Net;

class ScriptureReference
{
    private string _bookName;
    private int _chapter;
    private int _verse;
    private int _startVerse;
    private int _endVerse;


    public ScriptureReference(string book_name, int chapter, int verse) //constructor
    {
        _bookName = book_name;
        _chapter = chapter;
        _verse = verse;
    }

    public ScriptureReference(string book_name, int chapter, int startVerse, int endVerse) //constructor
    {
        _bookName = book_name;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    public string getScriptureReference() //method
    {
        if(_endVerse == 0)
        {
            return $"{_bookName} {_chapter}: {_verse}";
        }
        else
        {
            return $"{_bookName} {_chapter}: {_startVerse}-{_endVerse}";   
        }

    }

    public void DisplayReference() //method
    {
        if(_endVerse == 0)
        {
            Console.WriteLine($"{getScriptureReference}");
        }
        else
        {
            Console.WriteLine($"{getScriptureReference}");
        }
    }
}