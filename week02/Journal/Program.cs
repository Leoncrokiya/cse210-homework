using System;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();
        bool running = true;

        while (running)
        {
            Console.WriteLine("Journal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display all entries");
            Console.WriteLine("3. Save entries to file");
            Console.WriteLine("4. Load entries from file");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            if (!int.TryParse(Console.ReadLine(), out int userChoice) || userChoice < 1 || userChoice > 5)
            {
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.\n");
                continue;
            }

            switch (userChoice)
            {
                case 1:
                    CreateNewEntry(theJournal, promptGen);
                    break;

                case 2:
                    theJournal.DisplayAll();
                    break;
                    
                case 3:
                    Console.Write("Enter filename to save: ");
                    string saveFile = Console.ReadLine();
                    theJournal.SaveToFile(saveFile);
                    break;

                case 4:
                    Console.Write("Enter filename to load: ");
                    string loadFile = Console.ReadLine();
                    theJournal.LoadFromFile(loadFile);
                    break;

                case 5:
                    Console.WriteLine("Goodbye!");
                    running = false;
                    break;
            }
            Console.WriteLine();
        }
    }

    static void CreateNewEntry(Journal journal, PromptGenerator promptGen)
    {
        Entry newEntry = new Entry();
        newEntry._date = DateTime.Now.ToShortDateString();
        newEntry._promptText = promptGen.GetRandomPrompt();

        Console.WriteLine($"Prompt: {newEntry._promptText}");
        Console.Write("Your response: ");
        newEntry._entryText = Console.ReadLine();

        journal.AddEntry(newEntry);
        Console.WriteLine("Entry added!");
    }
}