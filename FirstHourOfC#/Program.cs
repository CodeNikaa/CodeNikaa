using System;
using System.Security.Cryptography.X509Certificates;

namespace FirstHour
{
    class firstHourOFCSharp
    {

        static void Main(string[] args)
        {
            //    int x = 10;
            //    int y = 20;
            //    int z = 30;

            // declaring a number variable with 32-bit 
            //int x = 10,
            //y = 20,
            //z = 30;
            //int age = 28; 
            //Console.WriteLine(x, y, z);

            // Converting data types into other data types string -> int32, string to int64 and so on
            string textAge = "28";
            int age = Convert.ToInt32(textAge);
            Console.WriteLine(age);

            Console.WriteLine(typeof(int));
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);

            // declaring strings and characters
            string firstName = "Tobias";
            Console.WriteLine(firstName);
            Console.WriteLine(typeof(string));

            char firstLetter = 'T';
            char number = '0';
            char emptyChar = '\0';
            Console.WriteLine(firstLetter);
            Console.WriteLine(number);
            Console.WriteLine(emptyChar);

            // declaring a number variable with 64-bit
            //long bigNumber = 1250000L;
            string bigNum = "1250000";
            long bigNumber = Convert.ToInt64(bigNum);
            Console.WriteLine(bigNumber);
            Console.WriteLine(typeof(long));
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MinValue);

            // declaring a double precision floating-point number
            //double negative = 149.99D;
            string negNumb = "-149.99";
            double negative = Convert.ToDouble(negNumb);
            Console.WriteLine(negative);
            Console.WriteLine(typeof(double));
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);

            // declaring a single precision floating-point number
            //float precision = 12.0000000001F;
            string prec = "12.0000000001";
            float precision = Convert.ToSingle(prec);
            Console.WriteLine(precision);
            Console.WriteLine(typeof(float));
            Console.WriteLine(float.MaxValue);
            Console.WriteLine(float.MinValue);

            // declaring a decimal floating-point number
            //decimal money = 14.99M;
            string moneyString = "14.99";
            decimal money = Convert.ToDecimal(moneyString);
            Console.WriteLine(money);
            Console.WriteLine(typeof(decimal));
            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(decimal.MinValue);

            //Boolean data type
            bool isMale = true;
            bool isFemale = false;
            Console.WriteLine("I am a Man is: " + isMale);
            Console.WriteLine("I am a Female is: " + isFemale);

        }
    }
}