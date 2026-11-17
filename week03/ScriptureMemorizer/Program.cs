
using System;

class Program
{
    static void Main(string[] args)
    {
        // Extra feature: The user can choose how many words
        // to hide in each round to control the difficulty.

        Reference reference = new Reference("Proverbs", 3, 5, 6);

        string text = "Trust in the Lord with all your heart and lean not on your own understanding. In all your ways acknowledge him and he will make your paths straight.";

        Scripture scripture = new Scripture(reference, text);

        Console.WriteLine("SCRIPTURE MEMORIZER");
        Console.WriteLine();
        Console.WriteLine("Choose your difficulty:");
        Console.WriteLine("1. Easy - Hide 1 word");
        Console.WriteLine("2. Medium - Hide 3 words");
        Console.WriteLine("3. Hard - Hide 5 words");
        Console.Write("Enter your choice: ");

    

 int numberToHide = 0;

while (numberToHide == 0)
{
    string choice = Console.ReadLine();

    if (choice == "1")
    {
        numberToHide = 1;
    }
    else if (choice == "2")
    {
        numberToHide = 3;
    }
    else if (choice == "3")
    {
        numberToHide = 5;
    }
    else
    {
        Console.Write("Invalid choice. Please enter 1, 2, or 3: ");
    }
}


        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();

            Console.Write("Press Enter to hide more words or type quit: ");

            string answer = Console.ReadLine();

            if (answer != null && answer.ToLower() == "quit")
            {
                return;
            }

            if (string.IsNullOrEmpty(answer))
            {
                scripture.HideRandomWords(numberToHide);
            }
        }

        Console.Clear();

        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine();
        Console.WriteLine("Well done! You have hidden all the words.");
    }
}
