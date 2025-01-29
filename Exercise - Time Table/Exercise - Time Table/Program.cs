using System;

namespace TimesTable_Exercise
{
    class timesTable_Exercise
    {   
        static void Main(string[] args)
        {
            Console.Write("Enter a number for TimeTable: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", i, userInput, i * userInput);
            }
        }
    }
}