using System;

namespace Dcit318_assignment1_11108240 
{
    public static class TicketProgram
    {
        public static void Run()
        {
            Console.WriteLine("Enter your age: ");

            if (!int.TryParse(Console.ReadLine(), out int age))
            {
                Console.WriteLine("Invalid input! Please enter a number. ");
            }
            else
            {
                 double ticketPrice;
                 if (age >= 65 || age <= 12)
                 {
                    ticketPrice = 7.00;
                 }
                 else
                 {
                    ticketPrice = 10.00;
                 }
                
                 Console.WriteLine($"Your ticket price is: GHC{ticketPrice}");
            }
        }
    }
}