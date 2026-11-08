using System;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";

        while (choice != "4")
        {
            Console.Clear();
            Console.WriteLine("~Mindfulness Activities~");
            Console.WriteLine("1.) Breathing Activity");
            Console.WriteLine("2.) Listing Activity");
            Console.WriteLine("3.) Reflection Activity");
            Console.WriteLine("4.) Quit");
            Console.Write("Please choose an option from above: ");

            choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", "This activity will help you relax by guiding you through slow breathing.");
                breathingActivity.RunActivity();
            }
            else if (choice == "2")
            {
                ListingActivity listingActivity = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                listingActivity.RunActivity();
            }
            else if (choice == "3")
            {
                ReflectionActivity reflectionActivity = new ReflectionActivity("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                reflectionActivity.RunActivity();
            }
        }

    Console.WriteLine("Thank you. Please come again.");
    }
}

