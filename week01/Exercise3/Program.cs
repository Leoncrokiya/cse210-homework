using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int num = randomGenerator.Next(1, 101);

        int guess = -1;

        while (guess != num)
        {
            Console.Write("What's your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess > num)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < num)
            {
                Console.WriteLine("Higher");
            }

            else
            {
                Console.WriteLine("Congratulations! You guessed the number.");
            }
        }

    }
}
