using System;

class Program
{
    static void Main(string[] args)
    {
        Menu myMenu = new Menu();
        Journal myJournal = new Journal();

        int response = 0;

        while(response !=5)
        {
            response = myMenu.ProcessMenu();
            switch(response)
            {
                case 1:
                    myJournal.CreateEntry();
                    Console.WriteLine("Your journal entry has been created.");
                    break;
                case 2:
                    myJournal.DisplayJournal();
                    Console.WriteLine("Your journal entries have been displayed.");
                    break;
                case 3:
                    Console.Write("Enter the filename: ");
                    string saveFilename = Console.ReadLine();

                    myJournal.SaveToFile(saveFilename);

                    Console.WriteLine("Your journal entry has been saved.");
                    break;
                case 4:          
                    Console.Write("Enter the filename: ");
                    string loadFilename = Console.ReadLine();

                    myJournal.LoadFromFile(loadFilename);

                    Console.WriteLine("Your journal entry has been loaded.");
                    break;
            }
        }
    }
}




