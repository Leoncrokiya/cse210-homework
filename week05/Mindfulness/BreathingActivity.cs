using System;

namespace Mindfulness
{
    public class BreathingActivity : Activity
    {
        public BreathingActivity()
        {
            _name = "Breathing Activity";
        }

        public void Run()
        {
            DisplayStartingMessage();
            Console.WriteLine();

            Console.WriteLine("Inhale...");
            ShowCountDown(4);

            Console.WriteLine("Exhale...");
            ShowCountDown(4);

            Console.WriteLine("Inhale...");
            ShowCountDown(4);

            Console.WriteLine("Exhale...");
            ShowCountDown(4);

            Console.WriteLine("Inhale...");
            ShowCountDown(4);

            Console.WriteLine("Exhale...");
            ShowCountDown(4);

            Console.WriteLine("Inhale...");
            ShowCountDown(4);

            Console.WriteLine("Exhale...");
            ShowCountDown(4);
            Console.WriteLine();

            DisplayEndingMessage();
        }
    }
}