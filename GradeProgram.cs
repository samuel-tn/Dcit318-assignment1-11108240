using System;

namespace Dcit318_assignment1_11108240
{
    public static class GradeProgram
    {
        public static void Run()
        {
            Console.Write("Enter  grade (0 - 100): ");

            if (!int.TryParse(Console.ReadLine(), out int grade))
            {
                Console.WriteLine("Invalid input! Please enter a number.");
                return;
            }

            if (grade < 0 || grade > 100)
            {
                Console.WriteLine("Error: Grade must be between 0 and 100.");
                return;
            }

            string letterGrade;
            if (grade >= 90)
                letterGrade = "A";
            else if (grade >= 80)
                letterGrade = "B";
            else if (grade >= 70)
                letterGrade = "C";
            else if (grade >= 60)
                letterGrade = "D";
            else
                letterGrade = "F";

            Console.WriteLine($"The letter grade is: {letterGrade}");
        }
    }
}
