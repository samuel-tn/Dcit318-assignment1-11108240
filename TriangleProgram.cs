using System;

namespace Dcit318_assignment1_11108240
{
    public static class TriangleProgram
    {
        public static void Run()
        {
            Console.WriteLine("Enter the lengths of the three sides of the triangle:");
            
            double sideM, sideN, sideO;
             Console.Write("Side 1: ");
            if (!double.TryParse(Console.ReadLine(), out sideM) || sideM <= 0)
            {
                Console.WriteLine("Invalid input! Side lengths must be positive numbers.");
                return;
            }
             Console.Write("Side 2: ");
            if (!double.TryParse(Console.ReadLine(), out sideN) || sideN <= 0)
            {
                Console.WriteLine("Invalid input! Side lengths must be positive numbers.");
                return;
            }
             Console.Write("Side 3: ");
            if (!double.TryParse(Console.ReadLine(), out sideO) || sideO <= 0)
            {
                Console.WriteLine("Invalid input! Side lengths must be positive numbers.");
                return;
            }

            if (sideM == sideN && sideN == sideO)
            {
                Console.WriteLine("The triangle is Equilateral");
            }
            else if (sideM == sideN || sideN == sideO || sideM == sideO)
            {
                Console.WriteLine("The triangle is Isosceles");
            }
            else
            {
                Console.WriteLine("The triangle is Scalene");
            }
        }
    }
}