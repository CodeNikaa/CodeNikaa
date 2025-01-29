using System;

namespace stringMethods
{
    class stringMethods
    {
        static void Main(string[] args)
        {
            string name = "Tobias";
            int age = 28;

            //fastest and easiest way to interpolate string and variables
            //called String Interpolation
            Console.WriteLine($"My name is {name} and i'm {age} years old!");

            //little bit tedious and complicated way, but works nontheless
            //called String Concatination
            Console.WriteLine("My name is " + name + " and i'm " + age + " years old!");

            //almost as fast as the first one, but perfect for legacy code
            //called Composite Formatting
            Console.WriteLine("My name is {0} and i'm {1} years old", name, age);


        }
    }
}