using System;

namespace Dcit318_assignment1_11108240
{
    public static class GradeProgram
    {
        public static void Run()
        {
            Console.WriteLine("Enter your score (0 - 100): ");

            if (!double.TryParse(Console.ReadLine(), out double score))
            {
                Console.WriteLine("Invalid input! Please enter a number.");
                return;
            }

            if (score < 0 || score > 100)
            {
                Console.WriteLine("Error: Please enter a score between 0 and 100.");
                return;
            }

            string letterGrade;
            if (score >= 90)
                letterGrade = "A";
            else if (score >= 80)
                letterGrade = "B";
            else if (score >= 70)
                letterGrade = "C";
            else if (score >= 60)
                letterGrade = "D";
            else
                letterGrade = "F";

            Console.WriteLine($"Your grade is: {letterGrade}");
        }
    }
}
