using System;
using System.Collections.Generic;
using System.Threading;
using Mindfulness;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Options:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select an option: ");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine();
        
            while (choice < 1 || choice > 4)
            {
                Console.Write("Enter Valid option: ");
                choice = int.Parse(Console.ReadLine()); 
                Console.WriteLine();
            }

            if (choice == 1)
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
            }

            else if (choice == 2)
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.Run();
            }

            else if (choice == 3)
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run();
            }

            else
            {
                Console.WriteLine("Goodbye!");
                break;
            }
        }
    }
}













































// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hi");


//         List<string> animations = new List<string>(); // { "|", "/", "-", "\\" };
//         animations.Add("|");
//         animations.Add("/");
//         animations.Add("-");
//         animations.Add("\\");
//         animations.Add("|");
//         animations.Add("/");
//         animations.Add("-");
//         animations.Add("\\");

//         // foreach (string s in animations)
//         // {
//         // }

//         DateTime startTime = DateTime.Now;
//         DateTime endTime = startTime.AddSeconds(5);

//         // Thread.Sleep(3000);

//         // DateTime currentTime = DateTime.Now;

//         int i = 0;

//         while (DateTime.Now < endTime)
//         {
//             string s = animations[i];
//             Console.WriteLine(s);
//             Thread.Sleep(1000);
//             Console.Write("\b \b");
//             // Console.WriteLine(".");
//             // Thread.Sleep(1000);
//             i++;

//             if (i >= animations.Count)
//             {
//                 i = 0;
//             }
//         }

//         Console.WriteLine("Done");
//     }
// }



















// Console.Write("+");

// Thread.Sleep(500);

// Console.Write("\b \b"); // Erase the + character
// Console.Write("-");

// ==================================================





        // Thread.Sleep(1000);
        // Console.WriteLine("welcome");

            // Console.Write("\b \b");
            // Console.WriteLine("|/-\|"[i % 4]); spinner