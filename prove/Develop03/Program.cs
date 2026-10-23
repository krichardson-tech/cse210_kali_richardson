using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        // Word myWord = new Word("Secret");

        // myWord.Display();
        // myWord.Hide();
        // Console.WriteLine();
        // myWord.Display();

        Scripture myScripture = new Scripture("Moses", 1, 39, "Behold, this is my work and my glory to bring to pass the immortality and eternal life of man.");

        while(!myScripture.CheckAllWordsHidden())
        {
            Console.Clear();
            myScripture.DisplayScripture();

            Console.WriteLine("\n");
            Console.Write("To hide words, press 'enter' - To stop program type 'quit': ");
            string response = Console.ReadLine();

            if (response.ToLower() == "quit")
            {
                break;
            }
            else if (response == "") 
            {
                myScripture.HideRandomWords();
            }
        }

        if (myScripture.CheckAllWordsHidden())
        {
            Console.Clear();
            myScripture.DisplayScripture();
        }
    }
}