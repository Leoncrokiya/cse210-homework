using System;
using System.Collections.Generic;

namespace Mindfulness
{
    public class ListingActivity : Activity
    {
        protected int _count = 0;
        protected List<string> _prompts = new List<string>();

        public void Run()
        {
            DisplayStartingMessage();
            Console.WriteLine();

            Console.WriteLine("List as many responses you can to the following prompt:");
            Console.WriteLine();

            Console.WriteLine($"--- {GetRandomPrompt()} ---");
            Console.WriteLine("You may begin in:");
            ShowCountDown(5);
            Console.WriteLine();

            List<string> list = GetListFromUser();
            _count = list.Count;
            DisplayEndingMessage();
            Console.WriteLine();

            Console.WriteLine($"You listed {_count} items.");
            Console.WriteLine();
        }

        public string GetRandomPrompt()
        {
            Random random = new Random();
            int index = random.Next(_prompts.Count);
            return _prompts[index];
        }
        public ListingActivity()
        {
            _name = "Listing Activity";
            _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

            _prompts.Add("Who are people that you appreciate?");
            _prompts.Add("What are personal strengths of yours?");
            _prompts.Add("Who are people that you have helped this week?");
            _prompts.Add("When have you felt the Holy Ghost this month?");
            _prompts.Add("Who are some of your personal heroes?");
            Console.WriteLine();
        }
        public List<string> GetListFromUser()
        {
            List<string> list = new List<string>();
            DateTime endTime = DateTime.Now.AddSeconds(_duration);
            while (DateTime.Now < endTime)
            {
                Console.Write("> ");
                string item = Console.ReadLine();
                if (!string.IsNullOrEmpty(item))
                {
                    list.Add(item);
                }
            }
            return list;
        }
    }
}