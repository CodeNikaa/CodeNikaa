using System;

namespace VerbatimStringLiteral
{
    class VerbatimStringLiteral
    {
        static void Main(string[] args)
        {
            string speech = "He said \"something\"";

            Console.Write(speech);

            string path = "C:\\C#\\Verbatim string literal\\Verbatim string literal\\Program.cs"; 

            Console.WriteLine(path);

            //$ + 
            //$"Your name is {name]"
            //"Your name is " + name

            path = @"C:\C#\Verbatim string literal\Verbatim string literal\Program.cs" + "\n New line Test";
            Console.WriteLine(path);

            string name = @"Hello ""someone""";
            Console.WriteLine(name);

            name = "Hello 'someone'";
            Console.WriteLine(name);
        }
    }
}