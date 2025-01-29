using System;

namespace stringIsNullOrEmpty
{
    class checkStrings
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Name: ");
            string userName = Console.ReadLine();

            Console.WriteLine(userName);

            //if (userName != "")
            //{
            //    Console.WriteLine($"{userName} is not valid. Please enter a valid name!");
            //    Console.ReadLine();
            //}

            //if (!userName.Equals(""))
            //{
            //    Console.WriteLine($"{userName} is not valid. Please enter a valid name!");
            //    Console.ReadLine();
            //}

            //if (string.IsNullOrEmpty(userName)) 
            //{
            //    Console.WriteLine($"{userName} is not valid. Please enter a valid name!");
            //    Console.ReadLine();
            //}

            while (string.IsNullOrEmpty(userName)) 
            {
                Console.WriteLine($"{userName} is not valid. \nPlease enter a valid name!");
                userName = Console.ReadLine();
                Console.Write($"Your name is {userName}");
            }
        }
    }
}