using System;

namespace HOLCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab konsoolis, mitu 'h', 'o' ja 'l' tähte on lauses "Hello World!"
            Console.WriteLine("Hello World!");
            string oneSentce = "Hello World".ToLower();

            int hCounter = 0;
            int oCounter = 0;
            int lCounter = 0;

            for (int i = 0; i < oneSentce.Length; i++)
            {
                if (oneSentce[i] == 'h')
                {
                    hCounter++;
                }
                else if (oneSentce[i] == 'o')
                {
                    oCounter++;
                }
                else if (oneSentce[i] == 'l')
                {
                    lCounter++;
                }

            }
            Console.WriteLine($"Selles lauses on {hCounter} 'h', {oCounter} 'o' ja {lCounter} 'l' sümbolit.");
        }
    }
}
