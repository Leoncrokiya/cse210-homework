using System;
using System.Threading;

namespace Mindfulness
{
    public class Activity
    {
        protected string _name = "";
        protected string _description = "";
        protected int _duration = 0;

        public Activity()
        {
            
        }
        public void DisplayStartingMessage()
        {
            Console.WriteLine($"Welcome to the {_name}.");
            Console.WriteLine();

            Console.WriteLine(_description);
            Console.WriteLine();

            Console.Write("How long, in seconds, would you like for your session? ");
            _duration = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Get ready...");
            ShowSpinner(3);
            Console.WriteLine();
        }

        public void DisplayEndingMessage()
        {
            Console.WriteLine("Well done!!");
            Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
            ShowSpinner(3);
            Console.WriteLine();
        }

        public void ShowSpinner(int seconds)
        {
            for (int i = 0; i < seconds; i++)
            {
                Console.Write("/");
                Thread.Sleep(250);
                Console.Write("\b");
                Console.Write("--");
                Thread.Sleep(250);
                Console.Write("\b");
                Console.Write("\\");
                Thread.Sleep(250);
                Console.Write("\b");
                Console.Write("|");
                Thread.Sleep(250);
                Console.Write("\b");
            }
            Console.WriteLine();
        }

        public void ShowCountDown(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine();
        }
    }
}
