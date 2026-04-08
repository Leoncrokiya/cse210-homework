using System;
using System.Diagnostics;

namespace Mindfulness
{
    public class BreathingActivity : Activity
    {
        public BreathingActivity()
        {
            _name = "Breathing Activity";
            _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        }

        public void Run()
        {
            DisplayStartingMessage();
            Console.WriteLine();

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            while (stopwatch.Elapsed.TotalSeconds < _duration)
            {
                Console.WriteLine("Inhale...");
                ShowCountDown(4);

                if (stopwatch.Elapsed.TotalSeconds >= _duration)
                    break;

                Console.WriteLine("Exhale...");
                ShowCountDown(4);
            }

            Console.WriteLine();
            DisplayEndingMessage();
        }
    }
}