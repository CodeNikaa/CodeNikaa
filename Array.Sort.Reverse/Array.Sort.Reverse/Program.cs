using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = new int[]
            {
                0, 1, 2, 3, 4, 5
            };

            //Array.Sort(numbers);

            foreach (var num in numbers)
            {
                Console.Write($"{num} ");
            }

            int[] sortNumbers = new int[numbers.Length];

            int x = 0;

            Console.WriteLine("");

            for (int i = numbers.Length -1; i >= 0; i--)
            {
                sortNumbers[x] = numbers[i];
                x++;
            }

            foreach (var num in sortNumbers)
            {
                Console.Write($"{num} ");
            }
        }
    }
}