using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        List<int> list = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 to stop.");

        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        while (num != 0)
        {
            list.Add(num);
            
            Console.Write("Enter a number: ");
            num = int.Parse(Console.ReadLine());
        }

        if (list.Count > 0)
        {
            int sum = 0;
            int max = int.MinValue;
            
            foreach (int n in list)
            {
                sum += n;
                if (n > max)
                {
                    max = n;
                }
            }
            
            double average = (double)sum / list.Count;

            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The max is: {max}");
        }

    }   

}
