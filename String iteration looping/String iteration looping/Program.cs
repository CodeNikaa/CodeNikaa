using System;
using System.Threading;

namespace stringIterationLooping
{
    class iterationLooping
    {
        static void Main(string[] args)
        {
            string message = "I reallly like C#";

            bool contains = false;

            for (int i = 0; i < message.Length; i++)
            {
                Thread.Sleep(100); //1000ms == 1 sec
                Console.Write(message[i]);

                if (message[i].Equals('C'))
                {
                    contains = true;
                    Console.WriteLine($"\nThe specified character {message[i]} exist in ur string");
                }
            }
        }
    }
}