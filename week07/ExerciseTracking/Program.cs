using System;
using System.Collections.Generic;
using ExerciseTracking;

namespace ExerciseTracking
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Activity> activities = new List<Activity>();

            Running running = new Running("03 Nov 2025", 30, 3f);
            Cycling cycling = new Cycling("04 Nov 2025", 45, 12f);
            Swimming swimming = new Swimming("05 Nov 2025", 60, 40);

            activities.Add(running);
            activities.Add(cycling);
            activities.Add(swimming);

            Console.WriteLine("Exercise tracking summary:");

            foreach (Activity activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }
        }
    }
}