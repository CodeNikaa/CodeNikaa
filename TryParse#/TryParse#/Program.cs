using System;

namespace TryParseFunction
{
    class tryParse
    {
        static void Main(string[] arg)
        {
            Console.Write("Enter a number: ");
             
            string numInput = Console.ReadLine();
            int num;

            bool success = int.TryParse(numInput, out num);

            while (success)
            {
                 Console.WriteLine(num);
            }
        }
    }
}