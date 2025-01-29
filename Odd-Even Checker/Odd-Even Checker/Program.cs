using System;

namespace oddevenChecker
{
    class oddeven
    {
        static void Main(string[] args)
        {
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = 2;

            int checkOddEven = num1 % num2;

            if (checkOddEven == 0)
            {
                Console.WriteLine("Your chosen number is even!!");
            }else
            {
                Console.WriteLine($"{num1} % {num2} does not equal zero/0");
            }

            Console.WriteLine(checkOddEven);

        }
    }
}