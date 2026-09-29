using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
// making the list for the numbers to be stored
        List<int> numbers = new List<int>();
        
        int userNumber = -1; //makes sure the while loop runs at least once since 0 breaks the loop
        
//instruction for user
        Console.WriteLine("Please enter a seires of numbers. When finished, type '0.'"); //instruction for user
        
// looping so the user can keep entering numbers
        while (userNumber != 0) {
            Console.Write("Enter a number: ");
            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);

// making sure entering 0 ends the input loop
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

// adding all the numbers for the sum
        int sum = 0; //makes the variable to later store the sum 
        foreach (int number in numbers) //goes through each number in the list
        {
            sum += number;
        }


//calculating average
    double average = ((float)sum / numbers.Count); //numbers.count counts how many numbers were entered

//finding largest number
    int largest = numbers[0]; //numbers[0] means the first item in a list

    foreach (int number in numbers) //goes through each number in the list
        {
            if (number > largest)
            {
                largest = number;
            }
        }

// displaying the sum, average, and largest number
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"the largest number is: {largest}");
    }
}