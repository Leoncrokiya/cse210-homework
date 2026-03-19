using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Isaiah", 6, 2);
        string text = "Above it stood the seraphims: each having six wings: with twain he covered his face, and with twain he covered his feet, and with twain he did fly.";
        ScriptureMemorizer memorizer = new ScriptureMemorizer(reference, text);
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine($"{memorizer.GetDisplayText()}");

            string option = Console.ReadLine();
            memorizer.HideRandomWords(3);

            if (option.ToLower() == "quit" || memorizer.IsCompletelyHidden())
            {
                break;
            }
        }

        Console.WriteLine("Goodbye!");

    }
}