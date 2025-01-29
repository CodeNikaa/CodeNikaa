using System;
using System.Globalization;

namespace pwchecker
{
    class PWChecker
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter password: ");
            string password = Console.ReadLine();
            Console.WriteLine(password);

            Console.WriteLine("Enter password again: ");
            string passwordCheck = Console.ReadLine();
            Console.WriteLine(passwordCheck);

            if (!password.Equals(string.Empty))
            {
                if (!passwordCheck.Equals(string.Empty))
                {
                    if (password.Length >= 10 && passwordCheck.Length >= 10)
                    {
                        if (password.Equals(passwordCheck))
                        {
                            Console.WriteLine("Password is Valid!");
                        } 
                        else
                        {
                            Console.WriteLine("Password is inValid");
                        }

                    }

                }

            }
            else
            {
                Console.WriteLine("Please enter a password: ");
            }

        }
    }
}  