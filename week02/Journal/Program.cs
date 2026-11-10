using System;

/*
 * EXCEEDING REQUIREMENTS (Creativity & Enhancements):
 * To exceed the core requirements, this program includes an extra piece of metadata
 * with every journal entry: an "Energy Level" tracker (e.g., Low, Medium, High). 
 * This helps track how physical energy fluctuates alongside daily reflections. 
 * Additionally, it uses a unique delimiter (~|~)` when saving and loading text files 
 * to prevent issues if commas or periods appear in the user's responses.
 */

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();
        string userChoice = "";

        Console.WriteLine("Welcome to the Journal Program!");

        while (userChoice != "5")
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            
            userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                string randomPrompt = promptGen.GetRandomPrompt();
                Console.WriteLine($"\nPrompt: {randomPrompt}");
                Console.Write("> ");
                string response = Console.ReadLine();

                Console.Write("How was your energy level today? (Low/Medium/High): ");
                string energy = Console.ReadLine();

                Entry newEntry = new Entry();
                newEntry._date = DateTime.Now.ToShortDateString();
                newEntry._promptText = randomPrompt;
                newEntry._entryText = response;
                newEntry._energyLevel = energy; // Matches the _energyLevel field in Entry.cs

                myJournal.AddEntry(newEntry);
                Console.WriteLine("Entry recorded successfully!\n");
            }
            else if (userChoice == "2")
            {
                myJournal.DisplayAll();
            }
            else if (userChoice == "3")
            {
                Console.Write("Enter filename to save (e.g., myJournal.txt): ");
                string filename = Console.ReadLine();
                myJournal.SaveToFile(filename);
            }
            else if (userChoice == "4")
            {
                Console.Write("Enter filename to load (e.g., myJournal.txt): ");
                string filename = Console.ReadLine();
                myJournal.LoadFromFile(filename);
            }
            else if (userChoice == "5")
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid option. Please choose a number between 1 and 5.\n");
            }
        }
    }
}