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

        Scripture[] scriptures =
        {
            new Scripture(
                "Moses",
                1,
                39,
                "Behold, this is my work and my glory - to bring to pass the immortality and eternal life of man."
            ),

            new Scripture(
                "Doctrine and Covenants",
                19,
                24,
                "I am Jesus Christ; I came by the will of the Father, and I do his will."
            ),

            new Scripture(
                "Luke",
                24,
                32,
                "And they said one to another, Did not our heart burn within us, while he talked with us by the way, and he opened to us the scriptures?"
            ),

            new Scripture(
                "Amos",
                3,
                7,
                "Surely the Lord God will do nothing, but he revealeth his secret unto his servants the prophets."
            ),

            new Scripture(
                "Isaiah",
                1,
                18,
                "Come now, and let us reason together, saith the Lord: though your sins be as scarlet, they shall be as white as snow; though they be red like crimson, they shall be as wool."
            )
        };

        RandomChoice randomChoice = new RandomChoice();
        Scripture myScripture = randomChoice.GetRandomChoice();

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