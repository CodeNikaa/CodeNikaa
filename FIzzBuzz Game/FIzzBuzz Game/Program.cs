using System;

namespace FizzBuzz
{
    class fizzbuzzGame
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number for FizzBuzz");

            int userInput = Convert.ToInt32(Console.ReadLine());

            bool threeOk = false;
            bool fiveOk = false;

           
            for ( int i = 1; i < userInput; i++ )
            {
                threeOk = i % 3 == 0;
                fiveOk = i % 5 == 0;

                if (threeOk)
                {
                    Console.WriteLine("Fizz");
                }
                else if (fiveOk)
                {
                    Console.WriteLine("Buzz");
                }
                else if (threeOk && fiveOk)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            } 
            
        }
    }
}