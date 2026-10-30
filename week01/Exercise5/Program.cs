using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        
        // Call each function in order, saving and passing data as needed
        DisplayWelcome();
        
        string name = PromptUserName();
        
        int number = PromptUserNumber();
        
        int squaredNumber = SquareNumber(number);
        
        DisplayResult(name, squaredNumber);
    }

    // --- Required Functions ---

    // 1. Displays the welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    // 2. Asks for and returns the user's name as a string
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    // 3. Asks for and returns the user's favorite number as an integer
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string input = Console.ReadLine();
        return int.Parse(input);
    }

    // 4. Accepts an integer parameter and returns that number squared
    static int SquareNumber(int number)
    {
        return number * number;
    }

    // 5. Accepts the user's name and squared number and displays them
    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
    }
}


