using System;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm ennustab, mis juhtub kasutajaga (kasutame Random klassi)

            string[] predictions = { "win a million", "fall in love", "buy youtube premium", "join the darkside forcookies" };
            Random rnd = new Random();
            int userNumber = rnd.Next(0, predictions.Length);
            Console.WriteLine($"This year you will {predictions[userNumber]}");


        }
    }
}
