using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Sandbox Project.");

        Console.Write("What's your name? ");
        string first_name = Console.ReadLine();

        Console.Write("What's your last name? ");
        string lastName = Console.ReadLine();

        Console.WriteLine($"Hello {first_name} {lastName}! Welcome to the world of C# programming.");
    }
}