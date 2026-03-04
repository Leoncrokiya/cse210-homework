using System;

class Program
{
    static void Main(string[] args)
    {
        void assignment()
        {
            Console.WriteLine("Welcome to the program!");

            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());

            int square = number * number;

            Console.WriteLine($"{name}, the square of {number} is {square}");
        }
                
        assignment();
    }

}