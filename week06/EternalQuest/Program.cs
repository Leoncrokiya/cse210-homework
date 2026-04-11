using System;
// using EternalQuest;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();

        while (true)
        {
            goalManager.Start();
            Console.WriteLine();

            Console.WriteLine("Menu Options");
            Console.WriteLine("1. Create a New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

            Console.Write("Select a Choice From the Menu: ");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            while( choice < 1 || choice > 6)
            {
                Console.Write("Select a Valid Choice: ");
                choice = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }

            if (choice == 1)
            {
                goalManager.CreateGoal();
            }

            else if (choice == 2)
            {
                goalManager.ListGoalDetails();

                Console.WriteLine();
            }

            else if (choice == 3)
            {
                goalManager.SaveGoals();
                Console.WriteLine();
            }

            else if (choice == 4)
            {
                goalManager.LoadGoals();

                Console.WriteLine();
            }

            else if (choice == 5)
            {
                goalManager.RecordEvent();

                Console.WriteLine();
            }

            else
            {
                Console.WriteLine("Goodbye!");
                break;
            }
        }
    }
}