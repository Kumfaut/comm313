// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Enter a date 'yyyy-MM-dd' or type 'exit' to quit");
            string input = Console.ReadLine();

            if (input.ToLower() == "exit")
            {
                break;
            }

            DateTime enteredDate;
            if (DateTime.TryParse(input, out enteredDate))
            {
                DateTime currentDate = DateTime.Now;
                TimeSpan difference = enteredDate - currentDate;

                if (difference.TotalDays > 0)
                {
                    Console.WriteLine($"There are {difference.Days} days until {enteredDate.ToShortDateString()}.");
                }
                else if (difference.TotalDays < 0)
                {
                    Console.WriteLine($"{Math.Abs(difference.Days)} days have passed since {enteredDate.ToShortDateString()}.");
                }
                else
                {
                    Console.WriteLine("The entered date is today!");
                }
            }
            else
            {
                Console.WriteLine("Invalid date format. Please try again.");
            }
        }
    }
}
