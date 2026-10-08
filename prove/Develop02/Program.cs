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
                    Console.WriteLine("Create");
                    break;
                case 2:
                    myJournal.DisplayJournal();
                    Console.WriteLine("Display");
                    break;
                case 3:
                // call readToFile()
                    Console.WriteLine("Save");
                    break;
                case 4:
                // call WriteToFile()
                    Console.WriteLine("Write");
                    break;            
            }
        }
    }
}