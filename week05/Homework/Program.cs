using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Assignment assignment1 = new Assignment();
            assignment1.SetStudentName("Leon Crokiya");
            assignment1.SetTopic("Math");

            Console.WriteLine(assignment1.GetSummary());
            Console.WriteLine();

            WritingAssignment assignment2 = new WritingAssignment();
            assignment2.SetStudentName("Rion Kurokiya");
            assignment2.SetTopic("English");
            assignment2.SetTitle("Essay on the Benefits of Exercise");

            Console.WriteLine(assignment2.GetWritingInformation());
            Console.WriteLine();

            MathsAssignment assignment3 = new MathsAssignment();
            assignment3.SetStudentName("Josiah Pillay");
            assignment3.SetTopic("Algebra");
            assignment3.SetTextbookSection("Section 5.2");
            assignment3.SetHomeworkList("Problems 1-10 on page 42");

            Console.WriteLine(assignment3.GetMathsSummary());
            Console.WriteLine();

            MathsAssignment assignment4 = new MathsAssignment();
            Console.WriteLine(assignment4.GetSummary());
            Console.WriteLine();
        }
    }
}