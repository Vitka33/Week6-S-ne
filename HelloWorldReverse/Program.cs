using System;

namespace HelloWorldReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab lauset "Hello World!" tagurpidi
            Console.WriteLine("Hello World!");
            string oneSentce = "Hello World";

            for (int i = oneSentce.Length - 1; i >= 0; i--)
            {
                Console.Write(oneSentce[i]);
            }
        }
    }
}
