class Menu
{
    public int DisplayMenu()
    {
        int input = 0;
        while (input < 1 || input > 6)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("> ");
            input = int.Parse(Console.ReadLine());
        }
        return input;
    }

    public int DisplayGoalMenu()
    {
        int input = 0;
        while (input < 1 || input > 3)
        {
            Console.WriteLine("What type of goal would you like to do?");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.Write("> ");
            input = int.Parse(Console.ReadLine());
        }
        return input;
    }
}