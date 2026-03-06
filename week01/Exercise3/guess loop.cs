using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Whatt's the magic number? ");
        int num = int.Parse(Console.ReadLine());

        Console.Write("What's your guess? ");
        int guess = int.Parse(Console.ReadLine());

        while (guess != num)
        {
            if (guess > num)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Higher");
            }

            Console.Write("What's your guess? ");
            guess = int.Parse(Console.ReadLine());
        }

        if (guess == num)
        {
            Console.WriteLine("Congratulations! You guessed the number.");
        }
    }
}